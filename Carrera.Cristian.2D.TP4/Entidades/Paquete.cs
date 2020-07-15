using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Entidades
{
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object obj, EventArgs e);
        public event DelegadoEstado InformaEstado;

        private string direccionEntrega;
        private string trackingId;
        private EEstado estado;

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public string TrackingID
        {
            get { return this.trackingId; }
            set { this.trackingId = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        #region Metodos
        /// <summary>
        /// Cambia el estado del paquete, cada 4 segundos hasta llegar al ultimo (Entregado)
        /// y guarda la informacion en la base de datos
        /// </summary>
        public void MockCicloDeVida()
        {

            if (this.InformaEstado != null)
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Thread.Sleep(4000);
                        this.Estado++;
                        this.InformaEstado(this, EventArgs.Empty);

                    }
                    PaqueteDAO.Insertar(this);

                }
                catch (Exception e)
                {

                    this.InformaEstado(e, EventArgs.Empty);
                }

            }

        }
        /// <summary>
        /// Retorna un string cargado con los datos  de un paquete implementando la interfaz IMostar
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).direccionEntrega);
        }
        /// <summary>
        /// Muestra los datos del paquete
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        /// <summary>
        /// Dos paquetes son el mismo por su id y retorna si lo son
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrackingID == p2.TrackingID);
        }
        /// <summary>
        /// retorna false si no son el mismo paquete reutilizando la sobrecarga del operador ==
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
