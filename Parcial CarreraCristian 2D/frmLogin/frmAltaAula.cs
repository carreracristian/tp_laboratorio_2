using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
namespace frmLogin
{
    public partial class frmAltaAula : Form
    {
        public frmAltaAula()
        {
            InitializeComponent();

        }
        #region Carga de datos a herramientas del form
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga de alumnos y cambio de backolor segun color selelccionado del comboboxColores
            List<Alumno> listaAl = new List<Alumno>();
            switch (cmbxColores.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Orange;
                    lbxAlumnosSinAsignar.Items.Clear();
                    foreach (var item in EstadosAplicacion.AlumnosSinAula)
                    {
                        if (item.ColorSala == (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedIndex)))
                            listaAl.Add(item);
                    }
                    foreach (var item in listaAl)
                    {
                        lbxAlumnosSinAsignar.Items.Add(item);
                    }
                    break;
                case 1:
                    this.BackColor = Color.Red;
                    lbxAlumnosSinAsignar.Items.Clear();
                    foreach (var item in EstadosAplicacion.AlumnosSinAula)
                    {
                        if (item.ColorSala == (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedIndex)))
                            listaAl.Add(item);
                    }
                    foreach (var item in listaAl)
                    {
                        lbxAlumnosSinAsignar.Items.Add(item);
                    }
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    lbxAlumnosSinAsignar.Items.Clear();
                    foreach (var item in EstadosAplicacion.AlumnosSinAula)
                    {
                        if (item.ColorSala == (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedIndex)))
                            listaAl.Add(item);
                    }
                    foreach (var item in listaAl)
                    {
                        lbxAlumnosSinAsignar.Items.Add(item);
                    }
                    break;
                case 3:
                    this.BackColor = Color.Green;
                    lbxAlumnosSinAsignar.Items.Clear();
                    foreach (var item in EstadosAplicacion.AlumnosSinAula)
                    {
                        if (item.ColorSala == (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedIndex)))
                            listaAl.Add(item);
                    }
                    foreach (var item in listaAl)
                    {
                        lbxAlumnosSinAsignar.Items.Add(item);
                    }
                    break;
            }
        }

        private void frmAltaAula_Load(object sender, EventArgs e)
        {
            //Carga de enumerados a los combobox correspondientes
            cmbxColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurnos.DataSource = Enum.GetValues(typeof(Eturno));
        }
        private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga de docentes segun su horario
            DateTime entradaMañana = new DateTime(01, 01, 01, 06, 00, 00);
            DateTime salidaMañana = new DateTime(01, 01, 01, 13, 00, 00);
            DateTime entradaTarde = new DateTime(01, 01, 01, 13, 00, 00);
            DateTime salidaTarde = new DateTime(01, 01, 01, 22, 00, 00);

            List<Docente> listaMañana = new List<Docente>();
            List<Docente> listaTarde = new List<Docente>();
            foreach (var item in EstadosAplicacion.ProfesoresSinaulas)
            {
                if ((item.Entrada >= entradaMañana) && (item.Salida <= salidaMañana))
                    listaMañana.Add(item);
                else
                    listaTarde.Add(item);
            }

            switch (cmbTurnos.SelectedIndex)
            {
                case 0:
                    comboBox3.Items.Clear();
                    foreach (var item in listaMañana)
                    {
                        comboBox3.Items.Add(item);
                    }
                    
                    break;
                case 1:
                    comboBox3.Items.Clear();
                    foreach (var item in listaTarde)
                    {
                        comboBox3.Items.Add(item);
                    }
                    break;
            }
        }
        #endregion

        #region Obtencion y almacenamiento de datos
        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            // TRAER DATOS
            Docente docente = (Docente)comboBox3.SelectedItem;
            //Remuevo el docente seleccionado para que no se lo pueda asignar a otra aula
            comboBox3.Items.Remove((Docente)comboBox3.SelectedItem);
            //Agrego al docente a a lista de docentes con aula
            EstadosAplicacion.ProfesoresConaulas.Add(docente);

            EColores colores = (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedItem));
            Eturno turno = (Eturno)Enum.Parse(typeof(Eturno), Convert.ToString(cmbTurnos.SelectedItem));
           
            // CREAR AULA   
            Aula aula = new Aula(colores, turno, docente);

            //if(int.Parse(lbxAlumnosDelAula.Items) =< 30)
            aula.Alumnos = lbxAlumnosDelAula.Items.Cast<Alumno>().ToList();
            // AGREGAR EN "COLECCION" QUE ESTA EN ESTADO APLICACION.
            EstadosAplicacion.Aulas.Add(aula);
            MessageBox.Show(aula.ToString(), "La cantidad de aulas creadas son: " + EstadosAplicacion.Aulas.Count);
            lbxAlumnosDelAula.Items.Clear();
            //AGREGAMOS ALUMNOS DEL AULA A LA LISTA DE ALUMNOS CON AULA
            List<Alumno> alumnosConAula = new List<Alumno>();

            foreach (var item in aula.Alumnos)
            {
                alumnosConAula.Add(item);
            }

            foreach (var item in alumnosConAula)
            {
                EstadosAplicacion.AlumnosConAula.Add(item);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lbxAlumnosSinAsignar.Items.Count > 0 && lbxAlumnosSinAsignar.SelectedItem != null)
            {
                // Pasamos de un listbox a otro.
                lbxAlumnosDelAula.Items.Add(lbxAlumnosSinAsignar.SelectedItem);

                // Removemos el objeto seleccionado.
                lbxAlumnosSinAsignar.Items.Remove((Alumno)lbxAlumnosSinAsignar.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay alumnos para asignar");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lbxAlumnosDelAula.Items.Count > 0 && lbxAlumnosDelAula.SelectedItem != null)
            {
                // Pasamos de un listbox a otro.
                lbxAlumnosSinAsignar.Items.Add(lbxAlumnosDelAula.SelectedItem);

                // Removemos el objeto seleccionado.
                lbxAlumnosDelAula.Items.Remove((Alumno)lbxAlumnosDelAula.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay alumnos para quitar");
            }
        }
        #endregion

    }
}
