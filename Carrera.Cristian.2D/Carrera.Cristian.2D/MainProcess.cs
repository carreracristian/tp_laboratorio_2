using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Carrera.Cristian._2D
{
    public class ProcessEventArgs
    {
        public string AlumnoEvaluado { get; set; }
        public string Docente { get; internal set; }
        public string Aula { get; internal set; }
        public Alumno ProximoAlumno { get; internal set; }
        public string TiempoTranscurrido { get; internal set; }
    }

    public class MainProcess : IDisposable
    {
        //creamos un delegado
        public delegate void ProcessEventHandler(object sender, ProcessEventArgs e);
        //crreamos el evento
        public event ProcessEventHandler ProcessEvent;
        //asignamos valores a constantes
        const int TIEMPOEVALUACION = 8000;
        const int TIEMPORECREO = 5000;
        const int TIEMPOINTERVALORECREO = 20000;
        // objeto de tipo Stopwatch para manejar el tiempo transcurrido de las evaluaciones
        private Stopwatch _swatch;
        private List<Docente> _docentes;
        private Queue<Alumno> _alumnnos;
        private List<Aula> _aulas;
        private List<Evaluacion> _evaluaciones;
        Conexion c = new Conexion();
        List<Thread> hilos;
        //Creamos una instancia de objeto MainProcess
        static MainProcess _instance;
        //encapsulamos el objeto instance
        public static MainProcess Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainProcess();
                 
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        private MainProcess()
        {
            // Suscribe al evento
        }
        /// <summary>
        /// Inicializamos atributos
        /// </summary>
        /// <param name="docentes"></param>
        /// <param name="alumnos"></param>
        /// <param name="aulas"></param>
        public void Initialize(List<Docente> docentes, Queue<Alumno> alumnos, List<Aula> aulas)
        {
            _swatch = new Stopwatch();
            _docentes = docentes;
            _alumnnos = alumnos;
            _aulas = aulas;
            _evaluaciones = new List<Evaluacion>();
        }
        /// <summary>
        /// Obtenemos un alumno y creamos una evaluacion
        /// </summary>
        public void DoProcess()
        {
            // Creamos el hilo pero con un factory.
            Task.Factory.StartNew(() =>
            {
                while(true)
                {
                    // Recorre los alumnos y crea una evaluación.
                    bool evaluar = false;

                    Alumno alumno = null;
                    if (_alumnnos.Count != 0)
                    {
                        alumno = _alumnnos.Dequeue();
                        evaluar = true;
                    }

                    if (evaluar)
                    {
                        Alumno proxAlumno = new Alumno();
                        if (_alumnnos.Count >= 1)
                            proxAlumno = _alumnnos.Peek();

                        Evaluar(alumno, proxAlumno);
                    }
                }
            });
        }
        
        public List<Alumno> alumnosEvaluados = new List<Alumno>();
        /// <summary>
        /// Asignamos los datos a las evaluaciones y las guardamos en la base de datos
        /// Serializamos los alumnos con sus atributos
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="proxAlumno"></param>
        void Evaluar(Alumno alumno, Alumno proxAlumno)
        {
            _swatch.Start();
            Evaluacion evaluacion;
            Random random = new Random();

            Array values = Enum.GetValues(typeof(EObservaciones));
            EObservaciones randomEObserv = (EObservaciones)values.GetValue(random.Next(values.Length));

            int idAlumno = alumno.IdAlumno;
            int idAulas = random.Next(1, _aulas.Count);
            int idDocentes = random.Next(1, _docentes.Count);
            int notaUno = random.Next(1, 10);
            int notaDos = random.Next(1, 10);
            float nf = ((notaUno + notaDos) / 2);

            evaluacion = new Evaluacion(idAlumno, idDocentes, idAulas, notaUno, notaDos, nf, randomEObserv.ToString());

            c.GuardarEvaluaciones(evaluacion);

            alumno.NotaUno = notaUno;
            alumno.NotaDos = notaDos;
            alumno.NotaFinal = nf;

            if (evaluacion.NotaFinal >= 6)
                alumno.GuardarAlumnosAprobados(alumno);
            else
                alumno.GuardarAlumnosDesaprobados(alumno);

            this._evaluaciones.Add(evaluacion);

            string docente = "Docente no establecido.";
            foreach (Docente item in _docentes)
            {
                if (item.Id == idDocentes)
                {
                    // Actualiza docente.
                    docente = item.ToString();
                }
            }

            string aula = string.Empty;
            foreach (Aula item in _aulas)
            {
                if (item.IdAula == idAulas)
                {
                    // Actualiza aula.
                    aula = item.ToString();
                }
            }

            alumnosEvaluados.Add(alumno);
            Thread.Sleep(TIEMPOEVALUACION);
            _swatch.Stop();

            ProcessEventArgs parametrosEvento = new ProcessEventArgs()
            {
                AlumnoEvaluado = alumno.ToString(),
                Aula = aula,
                Docente = docente,
                ProximoAlumno = proxAlumno,
                TiempoTranscurrido = $"Tiempo transcurrido:{_swatch.Elapsed.ToString()}"
            };

            ProcessEvent?.Invoke(this, parametrosEvento);
        }
        /// <summary>
        /// Elimino los hilos si aun existen
        /// </summary>
        public void Dispose()
        {
            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }
    }
}
