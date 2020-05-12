﻿using System;
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
    public partial class frmAltaAula : Form
    {
        public frmAltaAula()
        {
            InitializeComponent();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxColores.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Orange;
                    break;
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.BackColor = Color.Green;
                    break;
            }
            List<Alumno> listaAl = new List<Alumno>();

            foreach (var item in EstadosAplicacion.AlumnosSinAula)
            {
                if (item.ColorSala == (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedItem)))
                    listaAl.Add(item);
            }

            // Le pasamos la lista.
            lbxAlumnosSinAsignar.Items.AddRange(listaAl.ToArray());
        }

        private void frmAltaAula_Load(object sender, EventArgs e)
        {
            cmbxColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurnos.DataSource = Enum.GetValues(typeof(Eturno));
        }

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            // TRAER DATOS

            int select = comboBox3.SelectedIndex;
            Docente docente = (Docente)comboBox3.SelectedItem;
            //comboBox3.Items.RemoveAt(select); REVISAR
            EColores colores = (EColores)Enum.Parse(typeof(EColores), Convert.ToString(cmbxColores.SelectedItem));
            Eturno turno = (Eturno)Enum.Parse(typeof(Eturno), Convert.ToString(cmbTurnos.SelectedItem));
            //alumnos.Add(alumnosRecibidos);
            
            // CREAR AULA   
            Aula aula = new Aula(colores, turno, docente);

            aula.Alumnos = lbxAlumnosDelAula.Items.Cast<Alumno>().ToList();

            foreach (var item in aula.Alumnos)
            {
                if (aula.Alumnos.Count < 30)
                {
                    //aula.Alumnos.Add(alumnosRecibidos);
                }
                else
                    MessageBox.Show("El limite de alumnos por aulas es de 30", "No se puede agregar");
            }


            // AGREGAR EN "COLECCION" QUE ESTA EN ESTADO APLICACION.
            EstadosAplicacion.Aulas.Add(aula);
            MessageBox.Show(aula.ToString(), "La cantidad de aulas creadas son: " + EstadosAplicacion.Aulas.Count);
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
            if (lbxAlumnosDelAula.Items.Count > 0)
            {
                int select = lbxAlumnosDelAula.SelectedIndex;
                lbxAlumnosSinAsignar.Items.Add(lbxAlumnosDelAula.SelectedItem);
                lbxAlumnosDelAula.Items.Remove(select);
            }
        }

        private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime entradaMañana = new DateTime(01, 01, 01, 06, 00, 00);
            DateTime salidaMañana = new DateTime(01, 01, 01, 13, 00, 00);
            DateTime entradaTarde = new DateTime(01, 01, 01, 13, 00, 00);
            DateTime salidaTarde = new DateTime(01, 01, 01, 22, 00, 00);

            List<Docente> listaMañana = new List<Docente>();
            List<Docente> listaTarde = new List<Docente>();
            foreach (var item in EstadosAplicacion.Profesores)
            {
                if ((item.Entrada >= entradaMañana) && (item.Salida <= salidaMañana))
                    listaMañana.Add(item);
                else
                    listaTarde.Add(item);
            }

            switch (cmbTurnos.SelectedIndex)
            {
                case 0:
                    comboBox3.DataSource = listaMañana;
                    break;
                case 1:
                    comboBox3.DataSource = listaTarde;
                    break;
            }
        }
    }
}
