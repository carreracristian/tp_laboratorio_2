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

namespace frmLogin
{
    public partial class frmAltaDocente : Form
    {

        public frmAltaDocente()
        {
            InitializeComponent();
        }

        private void btnGuardarDocente_Click(object sender, EventArgs e)
        {
            // Obtenemos la informacion del docente.
            string nombre = txtNombreDocente.Text;
            string apellido = txtApellidoDocente.Text;
            txtNombreDocente.Clear();
            txtApellidoDocente.Clear();
            int valorTxtIngreso = 0;
            int valorTxtEgreso = 0;

            if (!int.TryParse(txtHoraIngresoDocente.Text, out valorTxtIngreso))
            {
                MessageBox.Show("Ingrese una hora de ingreso valida.");
                return;
            }
            txtHoraIngresoDocente.Clear();
            if (!int.TryParse(txtHoraSalidaDocente.Text, out valorTxtEgreso))
            {
                MessageBox.Show("Ingrese una hora de ingreso valida.");
                return;
            }

            DateTime horaEntrada = new DateTime().AddHours(valorTxtIngreso);
            DateTime horaSalida = new DateTime().AddHours(valorTxtEgreso);
            txtHoraIngresoDocente.Clear();
            txtHoraSalidaDocente.Clear();
            // sexo
            bool femenino;
            if (rbFemenino.Checked)
                femenino = true;
            else
                femenino = false;

            // valor hora
            double valorHora = 0;// = double.Parse(txtValorHoraDocente.Text);
            if (!double.TryParse(txtValorHoraDocente.Text, out valorHora))
            {
                MessageBox.Show("Ingrese valor valido.");
                return;
            }
            txtValorHoraDocente.Clear();
            // dni
            int dni = 0;// int.Parse(txtDniDocente.Text);
            if (!int.TryParse(txtDniDocente.Text, out dni)) 
            {
                MessageBox.Show("Ingrese un DNI valido.");
                return;
            }
            txtDniDocente.Clear();
            // instanciamos el docente
            Docente docente = new Docente(nombre, apellido, dni, femenino, horaEntrada, horaSalida, valorHora);
            EstadosAplicacion.Profesores.Add(docente);

            MessageBox.Show(docente.ToString(),"Cantidad de docentes dados de alta: "+EstadosAplicacion.Profesores.Count);
        }
        private void txtNombreDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtHoraIngresoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtHoraSalidaDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtValorHoraDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosDecimales(e);
        }

        private void txtDniDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtHoraSalidaDocente_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtHoraSalidaDocente.Text) < int.Parse(txtHoraIngresoDocente.Text))
                MessageBox.Show("La hora de salida no puede ser antes de la entrada","ERROR");
        }
    }
}
