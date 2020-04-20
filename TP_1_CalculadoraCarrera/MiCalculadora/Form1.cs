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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            lblResultado.Text = "0";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Cerrar calculadora?","SALIR", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
               string numero = lblResultado.Text;
            Numero num = new Numero();
            lblResultado.Text= num.DecimalBinario(numero);
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numero = lblResultado.Text;
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(numero);
        }

        void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperator.Text = "";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private static double Operar(string num1, string num2, string operador)
        {
            double resultado;
            Numero n1 = new Numero(num1);
            Numero n2 = new Numero(num2);

            return resultado = Calculadora.Operar(n1, n2, operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = Convert.ToString(cmbOperator.SelectedItem);
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, operador));
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }
    }
}
