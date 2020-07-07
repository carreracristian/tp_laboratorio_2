using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Carrera.Cristian._2D
{
    delegate void EvaluarAlumno(Alumno a);
    public enum EObservaciones
    {
        Satifactorio = 1,
        Decepcionante,
        Bueno,
        Regular
    }

    public partial class FrmSecundario : Form
    {
        Conexion c;
        const int TIEMPOEVALUACION = 8000;
        const int TIEMPORECREO = 5000;
        const int TIEMPOINTERVALORECREO = 20000;

        System.Threading.Timer timer;
        List<Thread> hilos;
        Queue<Alumno> alumnos;
        List<Aula> aulas;
        List<Alumno> alumnosEvaluados;
        List<Evaluacion> evaluaciones;
        List<Docente> docentes;
        Random randomDocente;
        Random randomNota;
        Random randomAula;
        Random randomObservacion;

        public FrmSecundario()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(timerElapsedTime_Tick);
            timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(20));

            c = new Conexion();
            hilos = new List<Thread>();
            alumnos = new Queue<Alumno>();
            alumnosEvaluados = new List<Alumno>();
            evaluaciones = new List<Evaluacion>();
            aulas = new List<Aula>();
            docentes = new List<Docente>();
            randomDocente = new Random();
            randomNota = new Random();
            randomAula = new Random();
            randomObservacion = new Random();
        }

        private void timerElapsedTime_Tick(object state)
        {
            if (labelRecreo.InvokeRequired)
            {
                labelRecreo.BeginInvoke((MethodInvoker)delegate
                    {
                        labelRecreo.Show();
                    });
            }
            else
            {
                labelRecreo.Show();
            }

            Thread.Sleep(TIEMPORECREO);

            if (labelRecreo.InvokeRequired)
            {
                labelRecreo.BeginInvoke((MethodInvoker)delegate
                {
                    labelRecreo.Hide();
                });
            }
            else
            {
                labelRecreo.Hide();
            }
        }

        private void FrmSecundario_Load(object sender, EventArgs e)
        {
            dataAulas.DataSource = c.MostrarAulas();
            dataAulas.RowHeadersVisible = false;
            dataAulas.ReadOnly = true;
            dataAulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAulas.AllowUserToAddRows = false;
            MainProcess.Instance.ProcessEvent += Instance_ProcessEvent;
        }
        /// <summary>
        /// Evento
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void Instance_ProcessEvent(object sender, ProcessEventArgs e)
        {
            /* Asigno a la vista los datos */
            SetearTextBox(e.AlumnoEvaluado.ToString(), txtAlumnoEvaluado);
            SetearTextBox(e.ProximoAlumno.ToString(), txtProxAlumno);
            SetearTextBox(e.Docente.ToString(), txtDocente);
            SetearTextBox(e.Aula.ToString(), txtAula);

            if (labelTiempo.InvokeRequired)
            {
                labelTiempo.BeginInvoke((MethodInvoker)delegate
                {
                    labelTiempo.Text = e.TiempoTranscurrido;
                });
            }
            else
                labelTiempo.Text = e.TiempoTranscurrido;


            if (lbxAlumnosEvaluados.InvokeRequired)
            {
                lbxAlumnosEvaluados.BeginInvoke((MethodInvoker)delegate
                {
                    lbxAlumnosEvaluados.Items.Add(e.AlumnoEvaluado);
                });
            }
            else
                lbxAlumnosEvaluados.Items.Add(e.AlumnoEvaluado);
        }

        void SetearTextBox(string mensaje, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
                {
                    txt.Text = mensaje;
                });
            }
            else
                txt.Text = mensaje;
        }

        void CargarEvaluacionesABaseDeDatos()
        {
            foreach (Evaluacion item in evaluaciones)
            {
                c.GuardarEvaluaciones(item);
            }
        }

        private void labelRecreo_Click(object sender, EventArgs e)
        {

        }
    }
}
