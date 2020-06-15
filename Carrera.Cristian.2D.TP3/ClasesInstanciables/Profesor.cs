using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        public Queue<Universidad.EClases> clasesDelDia;
        public static Random random;

        static Profesor()
        {
           Profesor.random = new Random();
        }
        public Profesor():base()
        {
           
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        /// <summary>
        /// Mostramos los datos del profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
            
        }
        /// <summary>
        /// Implementamos el metodo abstracto ParticiparEnClase()
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
           
        }
        /// <summary>
        /// hacemos publicos los datos del profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Sobrecarga del operador == para mostrar profesores por clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != para mostrar profesores por clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// Asignamos dos clases al azar para cada profesor
        /// </summary>
        public void _randomClases()
        {
            Universidad.EClases aux;
            while (this.clasesDelDia.Count < 2)
            {
                aux = (Universidad.EClases)Profesor.random.Next(1, 4);
                this.clasesDelDia.Enqueue(aux);
            }

        }
        public override bool Equals(object obj)
        {
            if (obj is Profesor)
            {
                return base.Equals(obj);
            }
            return false;
        }
    }
}
