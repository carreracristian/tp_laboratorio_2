﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        #region Metodos
        /// <summary>
        /// Muestra los datos de cada paquete, implementando una interfaz.
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string paquetes = " ";
            foreach (Paquete p in ((Correo)elemento).Paquetes)
            {
                paquetes += string.Format("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());

            }
            return paquetes;
        }
        /// <summary>
        /// Elimina los hilos que ya no se ejecutan
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilos in this.mockPaquetes)
            {
                if (hilos.IsAlive)
                {
                    hilos.Abort();
                }
            }
        }
        /// <summary>
        /// Suma un paquete a la lista si este no esta repetido, si esta repetido lanza una excepcion,
        /// crea un hilo, lo ejecuta y lo guarda a la lista de hilos.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete unPaquete in c.Paquetes)
            {
                if (unPaquete == p)
                {
                    throw new TrackingIDRepetidoException("Error. El paquete ingresado ya existe!");
                }

            }
            c.paquetes.Add(p);

            Thread cicloDeVida = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(cicloDeVida);
            cicloDeVida.Start();

            return c;
        }
        #endregion

    }
}
