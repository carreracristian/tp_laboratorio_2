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
        protected override string MostrarDatos()
        {
            return $"Id NUMERO: {legajo}" +
                   $"CLASES DEL DIA: {clasesDelDia.ToString()}" +
                   $"NOMBRE COMPLETO:{Apellido}, {Nombre} " +
                   $"NACIONALIDAD: {Nacionalidad.ToString()}";
        }
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
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
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
