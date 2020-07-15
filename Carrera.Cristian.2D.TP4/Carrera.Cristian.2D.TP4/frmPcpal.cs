using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Carrera.Cristian._2D.TP4
{
    public partial class frmPcpal : Form
    {
        private Correo correo;
        public frmPcpal()
        {
            InitializeComponent();

            this.correo = new Correo();
        }
        /// <summary>
        /// Mostrara la informacion que guardo en el txt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> paquete)
        {
            if (paquete != null)
            {
                rtbMostrar.Text = paquete.MostrarDatos(paquete);
                paquete.MostrarDatos(paquete).Guardar("Correos");
            }
        }
        /// <summary>
        /// mostrara el correo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lbxEntregado.SelectedItem);
        }
        /// <summary>
        /// Actualiza los paquetes, limpiando cada lista
        /// </summary>
        private void ActualizarEstados()
        {
            this.lbxIngresado.Items.Clear();
            this.lbxEnViaje.Items.Clear();
            this.lbxEntregado.Items.Clear();
            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case EEstado.Ingresado:
                        lbxIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        lbxEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        lbxEntregado.Items.Add(p);
                        break;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
            if (sender is Exception)
            {
                MessageBox.Show("Lo Sentimos, Se produjo un error al conectarse con la base de datos. "," Por favor, revise su conexion.");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete unPaquete = new Paquete(this.txtDireccion.Text, this.mtxTracking.Text);
                unPaquete.InformaEstado += paq_InformaEstado;
                this.correo += unPaquete;
            }
            catch (TrackingIDRepetidoException ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.ActualizarEstados();
        }

        /// <summary>
        /// Mostrara todos los correos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// cuando se cierre el formulario. cerrara todos los hilos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
    }
}
