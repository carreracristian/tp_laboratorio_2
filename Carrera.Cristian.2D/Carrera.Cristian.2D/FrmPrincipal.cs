using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using System.IO;
using Archivos;
using System.Threading;

namespace Carrera.Cristian._2D
{
    public partial class FrmPrincipal : Form
    {
        List<Docente> docentes;
        Conexion c;

        public FrmPrincipal()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
             docentes = Docente.Deserializar<List<Docente>>($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Docentes.xml");

            foreach (var item in docentes)
            {
                if (!c.DocenteRegistrado(item.Dni))
                    MessageBox.Show(c.InsertarDocentesXml(item.Nombre, item.Apellido, item.Edad, item.Sexo, item.Dni, item.Direccion, item.Email));
                //else
                    //MessageBox.Show("Docente ya registrado","Carga de docentes");
            }

            dataDocentes.DataSource = c.MostrarDocentes();
            dataDocentes.RowHeadersVisible = false;
            dataDocentes.ReadOnly = true;
            dataDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDocentes.AllowUserToAddRows = false;

            dataAlumnos.DataSource = c.MostrarAlumnos();
            dataAlumnos.RowHeadersVisible = false;
            dataAlumnos.ReadOnly = true;
            dataAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAlumnos.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Ejecutamos evento que leva a avisar al otro formulario que arranque.
            var docentes = c.ObtenerDocentes();
            var alumnos = c.ObtenerAlumnos();
            var aulas = c.ObtenerAulas();

            MainProcess.Instance.Initialize(docentes, alumnos, aulas);
            MainProcess.Instance.DoProcess();
        }
    }
}
