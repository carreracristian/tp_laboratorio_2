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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            List<Aula> listaAl = new List<Aula>();
            foreach (var item in EstadosAplicacion.Aulas)
            {
                listaAl.Add(item);
            }
            listBoxAulas.DataSource = listaAl;
            /*foreach (var item in EstadosAplicacion.Aulas)
            {
                listBoxAulas.Items.Add(item.Nombre);
            }*/

        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDocente miDocente = new frmAltaDocente();
            miDocente.ShowDialog();
        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno miAlumno = new frmAltaAlumno();
            //miAlumno.MdiParent = this;
            miAlumno.ShowDialog();
        }

        private void altaDeNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaNoDocente miNoDocente = new frmAltaNoDocente();
            miNoDocente.ShowDialog();
        }

        private void altaDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAula miAula = new frmAltaAula();
            miAula.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro que quiere salir??", "SALIENDO DEL SISTEMA");
            //this.Close();
        }

        private void informacionDeResponsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacionDeResponsables miResponsable = new frmInformacionDeResponsables();
            miResponsable.MdiParent = this;
            miResponsable.Show();

        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoDocentes sueldoDocente = new frmSueldoDocentes();
            sueldoDocente.MdiParent = this;
            sueldoDocente.Show();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoNoDocentes sueldoNoDocente = new frmSueldoNoDocentes();
            sueldoNoDocente.MdiParent = this;
            sueldoNoDocente.Show();
        }

        private void recaudacioPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudacionPorAula recaudacionPorAula = new frmRecaudacionPorAula();
            recaudacionPorAula.MdiParent = this;
            recaudacionPorAula.Show();
        }

        private void recaudacionTotalDelJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudacionTotalDelJardin recaudacionTotalJardin = new frmRecaudacionTotalDelJardin();
            recaudacionTotalJardin.MdiParent = this;
            recaudacionTotalJardin.Show();
        }
        
        private void crearDocentesResponsablesYAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Horarios de ingreso
            DateTime entradaD1 = new DateTime(01, 01, 01, 07, 00, 00);
            DateTime entradaD2 = new DateTime(01, 01, 01, 08, 00, 00);
            DateTime entradaD3 = new DateTime(01, 01, 01, 17, 00, 00);
            DateTime entradaD4 = new DateTime(01, 01, 01, 15, 00, 00);
            DateTime entradaD5 = new DateTime(01, 01, 01, 13, 00, 00);
            //Horarios de salida
            DateTime salidaD1 = new DateTime(01, 01, 01, 12, 00, 00);
            DateTime salidaD2 = new DateTime(01, 01, 01, 11, 00, 00);
            DateTime salidaD3 = new DateTime(01, 01, 01, 22, 00, 00);
            DateTime salidaD4 = new DateTime(01, 01, 01, 20, 00, 00);
            DateTime salidaD5 = new DateTime(01, 01, 01, 19, 00, 00);
            //Hardcodeo de docentes
            Docente d1 = new Docente("Juan", "Perez", 12345, false, entradaD1, salidaD1, 350);
            Docente d2 = new Docente("Analia", "Gomez", 32155, true, entradaD2, salidaD2, 450);
            Docente d3 = new Docente("Pedro", "Correa", 98457, false, entradaD3, salidaD3, 250);
            Docente d4 = new Docente("Cristian", "Diaz", 23564, false, entradaD4, salidaD4, 280);
            Docente d5 = new Docente("German", "Lopez", 35241, false, entradaD5, salidaD5, 400);
            
            EstadosAplicacion.Profesores.Add(d1);
            EstadosAplicacion.Profesores.Add(d2);
            EstadosAplicacion.Profesores.Add(d3);
            EstadosAplicacion.Profesores.Add(d4);
            EstadosAplicacion.Profesores.Add(d5);
            //Hardcodeo de Responsables
            Responsable r1 = new Responsable("Belen", "Perez", 12345, true, EParentesco.Tia, "12345");
            Responsable r2 = new Responsable("Luciana", "Rodriguez", 54216, true, EParentesco.Madre, "32547");
            Responsable r3 = new Responsable("Carlos", "Castro", 23458, false, EParentesco.Tio, "98654");
            Responsable r4 = new Responsable("Bratt", "Pit", 63527, false, EParentesco.Abuelo, "65458");
            Responsable r5 = new Responsable("Camila", "Lollo", 14859, true, EParentesco.Tia, "96852");
            Responsable r6 = new Responsable("Enzo", "Perez", 15126, false, EParentesco.Abuelo, "74526");
            Responsable r7 = new Responsable("Luis", "Suarez", 98543, false, EParentesco.Padre, "32875");
            Responsable r8 = new Responsable("Lionel", "Messi", 12985, false, EParentesco.Tio, "36851");
            Responsable r9 = new Responsable("Lorena", "Cavani", 63528, true, EParentesco.Abuela, "32985");
            Responsable r10 = new Responsable("Ivael", "Tercero", 89452, false, EParentesco.Padre, "32568");

            EstadosAplicacion.Responsables.Add(r1);
            EstadosAplicacion.Responsables.Add(r2);
            EstadosAplicacion.Responsables.Add(r3);
            EstadosAplicacion.Responsables.Add(r4);
            EstadosAplicacion.Responsables.Add(r5);
            EstadosAplicacion.Responsables.Add(r6);
            EstadosAplicacion.Responsables.Add(r7);
            EstadosAplicacion.Responsables.Add(r8);
            EstadosAplicacion.Responsables.Add(r9);
            EstadosAplicacion.Responsables.Add(r10);
            //Hardcodeo de Alumnos
            Alumno a1 = new Alumno("Ivael", "Tercero", 89452, false, 4500, r1, 1,EColores.Amarillo);
            Alumno a2 = new Alumno("Ana", "Gomez", 41528, true, 4000, r2, 2, EColores.Naranja);
            Alumno a3 = new Alumno("Luciana", "Centurion", 85699, true, 5500, r3, 3, EColores.Rojo);
            Alumno a4 = new Alumno("Belen", "Perez", 74852, true, 3500, r4, 4, EColores.Verde);
            Alumno a5 = new Alumno("carlos", "Gamarra", 52428, false, 5000, r5, 5, EColores.Verde);
            Alumno a6 = new Alumno("Juan", "Lopez", 41288, false, 4000, r6, 6, EColores.Amarillo);
            Alumno a7 = new Alumno("Pedro", "Gomez", 82545, false, 4500, r7, 7, EColores.Naranja);
            Alumno a8 = new Alumno("Raul", "Centurion", 85958, false, 5500, r8, 8, EColores.Rojo);
            Alumno a9 = new Alumno("Rodrigo", "Perez", 84588, false, 3500, r9, 9, EColores.Verde);
            Alumno a10 = new Alumno("Luciana", "Gamarra", 74528, true, 4000, r10, 10, EColores.Amarillo);
            Alumno a11 = new Alumno("Brenda", "Gomez", 52858, true, 5000, r1, 11, EColores.Naranja);
            Alumno a12 = new Alumno("Ana", "Lopez", 85854, true, 4500, r2, 12, EColores.Rojo);
            Alumno a13 = new Alumno("Raul", "Gamarra", 41288, false, 5500, r4, 13, EColores.Verde);
            Alumno a14 = new Alumno("Juan", "Centurion", 34543, false, 3500, r3, 14, EColores.Amarillo);
            Alumno a15 = new Alumno("Rodrigo", "Lopez", 45654, false, 4000, r5, 15, EColores.Naranja);
            Alumno a16 = new Alumno("Pedro", "Perez", 45664, false, 4500, r9, 16, EColores.Rojo);
            Alumno a17 = new Alumno("Brenda", "Gomez", 78667, true, 5000, r6, 17, EColores.Verde);
            Alumno a18 = new Alumno("Luciana", "Gamarra", 46565, true, 5500, r8, 18, EColores.Amarillo);
            Alumno a19 = new Alumno("Juan", "Lopez", 14538, false, 4000, r7, 19, EColores.Naranja);
            Alumno a20 = new Alumno("Raul", "Perez", 96852, false, 3500, r10, 20, EColores.Rojo);
            Alumno a21 = new Alumno("Ana", "Centurion", 41528, true, 4500, r3, 21, EColores.Verde);
            Alumno a22 = new Alumno("Ivael", "Gamarra", 14258, false, 5000, r2, 22, EColores.Amarillo);
            Alumno a23 = new Alumno("Rodrigo", "Lopez", 69365, false, 5500, r4, 23, EColores.Naranja);
            Alumno a24 = new Alumno("Brenda", "Perez", 85963, true, 4000, r1, 24, EColores.Rojo);
            Alumno a25 = new Alumno("Ana", "Centurion", 74258, true, 3500, r5, 25, EColores.Verde);
            Alumno a26 = new Alumno("Ivael", "Lopez", 12459, false, 4500, r9, 26, EColores.Amarillo);
            Alumno a27 = new Alumno("Luciana", "Gomez", 98652, true, 5500, r6, 27, EColores.Naranja);
            Alumno a28 = new Alumno("Pedro", "Perez", 74852, false, 3500, r8, 28, EColores.Rojo);
            Alumno a29 = new Alumno("Juan", "Lopez", 85965, false, 4000, r7, 29, EColores.Verde);
            Alumno a30 = new Alumno("Raul", "Centurion", 47528, false, 4500, r1, 30, EColores.Amarillo);
            Alumno a31 = new Alumno("Rodrigo", "Gamarra", 85544, false, 5000, r2, 31, EColores.Naranja);
            Alumno a32 = new Alumno("Luciana", "Gomez", 68858, true, 5500, r4, 32, EColores.Rojo);
            Alumno a33 = new Alumno("Pedro", "Lopez", 89452, false, 3500, r3, 33, EColores.Verde);
            Alumno a34 = new Alumno("Brenda", "Perez", 36554, true, 4000, r10, 34,EColores.Amarillo);
            Alumno a35 = new Alumno("Ivael", "Centurion", 58253, false, 4500, r5, 35, EColores.Naranja);
            Alumno a36 = new Alumno("Juan", "Perez", 74258, false, 5500, r6, 36, EColores.Rojo);
            Alumno a37 = new Alumno("Luciana", "Gomez", 65452, true, 3500, r8, 37, EColores.Verde);
            Alumno a38 = new Alumno("Raul", "Gamarra", 45254, false, 4500, r9, 38, EColores.Amarillo);
            Alumno a39 = new Alumno("Rodrigo", "Centurion", 14754, false, 4000, r3, 39, EColores.Naranja);
            Alumno a40 = new Alumno("Ana", "Lopez", 36852, true, 5000, r7, 40, EColores.Rojo);
            Alumno a41 = new Alumno("Juan", "Gomez", 45592, false, 5500, r2, 41, EColores.Verde);
            Alumno a42 = new Alumno("Pedro", "Perez", 12325, false, 4500, r3, 42,EColores.Amarillo);
            Alumno a43 = new Alumno("Raul", "Centurion", 74589, false, 3500, r4, 43, EColores.Naranja);
            Alumno a44 = new Alumno("Brenda", "Gamarra", 14585, true, 4000, r10, 44, EColores.Rojo);
            Alumno a45 = new Alumno("Juan", "Lopez", 78452, false, 4500, r5, 45, EColores.Verde);
            Alumno a46 = new Alumno("Rodrigo", "Gamarra", 25745, false, 5500, r6, 46, EColores.Amarillo);
            Alumno a47 = new Alumno("Raul", "Gomez", 69582, false, 5000, r9, 47, EColores.Naranja);
            Alumno a48 = new Alumno("Pedro", "Perez", 74523, false, 3500, r8, 48, EColores.Rojo);
            Alumno a49 = new Alumno("Juan", "Gamarra", 12359, false, 4000, r3, 49, EColores.Verde);
            Alumno a50 = new Alumno("Ana", "Centurion", 95627, true, 4500, r10, 50, EColores.Naranja);

            EstadosAplicacion.AlumnosSinAula.Add(a1);
            EstadosAplicacion.AlumnosSinAula.Add(a2);
            EstadosAplicacion.AlumnosSinAula.Add(a3);
            EstadosAplicacion.AlumnosSinAula.Add(a4);
            EstadosAplicacion.AlumnosSinAula.Add(a5);
            EstadosAplicacion.AlumnosSinAula.Add(a6);
            EstadosAplicacion.AlumnosSinAula.Add(a7);
            EstadosAplicacion.AlumnosSinAula.Add(a8);
            EstadosAplicacion.AlumnosSinAula.Add(a9);
            EstadosAplicacion.AlumnosSinAula.Add(a10);
            EstadosAplicacion.AlumnosSinAula.Add(a11);
            EstadosAplicacion.AlumnosSinAula.Add(a12);
            EstadosAplicacion.AlumnosSinAula.Add(a13);
            EstadosAplicacion.AlumnosSinAula.Add(a14);
            EstadosAplicacion.AlumnosSinAula.Add(a15);
            EstadosAplicacion.AlumnosSinAula.Add(a16);
            EstadosAplicacion.AlumnosSinAula.Add(a17);
            EstadosAplicacion.AlumnosSinAula.Add(a18);
            EstadosAplicacion.AlumnosSinAula.Add(a19);
            EstadosAplicacion.AlumnosSinAula.Add(a20);
            EstadosAplicacion.AlumnosSinAula.Add(a21);
            EstadosAplicacion.AlumnosSinAula.Add(a22);
            EstadosAplicacion.AlumnosSinAula.Add(a23);
            EstadosAplicacion.AlumnosSinAula.Add(a24);
            EstadosAplicacion.AlumnosSinAula.Add(a25);
            EstadosAplicacion.AlumnosSinAula.Add(a26);
            EstadosAplicacion.AlumnosSinAula.Add(a27);
            EstadosAplicacion.AlumnosSinAula.Add(a28);
            EstadosAplicacion.AlumnosSinAula.Add(a29);
            EstadosAplicacion.AlumnosSinAula.Add(a30);
            EstadosAplicacion.AlumnosSinAula.Add(a31);
            EstadosAplicacion.AlumnosSinAula.Add(a32);
            EstadosAplicacion.AlumnosSinAula.Add(a33);
            EstadosAplicacion.AlumnosSinAula.Add(a34);
            EstadosAplicacion.AlumnosSinAula.Add(a35);
            EstadosAplicacion.AlumnosSinAula.Add(a36);
            EstadosAplicacion.AlumnosSinAula.Add(a37);
            EstadosAplicacion.AlumnosSinAula.Add(a38);
            EstadosAplicacion.AlumnosSinAula.Add(a39);
            EstadosAplicacion.AlumnosSinAula.Add(a40);
            EstadosAplicacion.AlumnosSinAula.Add(a41);
            EstadosAplicacion.AlumnosSinAula.Add(a42);
            EstadosAplicacion.AlumnosSinAula.Add(a43);
            EstadosAplicacion.AlumnosSinAula.Add(a44);
            EstadosAplicacion.AlumnosSinAula.Add(a45);
            EstadosAplicacion.AlumnosSinAula.Add(a46);
            EstadosAplicacion.AlumnosSinAula.Add(a47);
            EstadosAplicacion.AlumnosSinAula.Add(a48);
            EstadosAplicacion.AlumnosSinAula.Add(a49);
            EstadosAplicacion.AlumnosSinAula.Add(a50);
            //hardcodeo de aulas(prueba)
            Aula au1 = new Aula(EColores.Amarillo, Eturno.mañana, d1);
            au1.Alumnos.Add(a1);
            au1.Alumnos.Add(a2);
            au1.Alumnos.Add(a3);
            au1.Alumnos.Add(a4);
            au1.Alumnos.Add(a5);
            au1.Alumnos.Add(a6);
            au1.Alumnos.Add(a7);
            au1.Alumnos.Add(a8);
            au1.Alumnos.Add(a9);
            Aula au2 = new Aula(EColores.Naranja, Eturno.tarde, d2);
            au2.Alumnos.Add(a10);
            au2.Alumnos.Add(a12);
            au2.Alumnos.Add(a13);
            au2.Alumnos.Add(a14);
            au2.Alumnos.Add(a15);
            au2.Alumnos.Add(a16);
            au2.Alumnos.Add(a17);
            au2.Alumnos.Add(a18);
            au2.Alumnos.Add(a19);
            Aula au3 = new Aula(EColores.Rojo, Eturno.mañana, d3);
            au3.Alumnos.Add(a21);
            au3.Alumnos.Add(a22);
            au3.Alumnos.Add(a23);
            au3.Alumnos.Add(a24);
            au3.Alumnos.Add(a25);
            au3.Alumnos.Add(a26);
            au3.Alumnos.Add(a27);
            au3.Alumnos.Add(a28);
            au3.Alumnos.Add(a29);
            Aula au4 = new Aula(EColores.Verde, Eturno.tarde, d4);
            au4.Alumnos.Add(a31);
            au4.Alumnos.Add(a32);
            au4.Alumnos.Add(a33);
            au4.Alumnos.Add(a34);
            au4.Alumnos.Add(a35);
            au4.Alumnos.Add(a36);
            au4.Alumnos.Add(a37);
            au4.Alumnos.Add(a38);
            au4.Alumnos.Add(a39);
            //Agrego aulas a Estado de aplicacion
            EstadosAplicacion.Aulas.Add(au1);
            EstadosAplicacion.Aulas.Add(au4);
            EstadosAplicacion.Aulas.Add(au3);
            EstadosAplicacion.Aulas.Add(au2);
        }

        private void buscarAlumnoPorApellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaDeAlumno buscarAlumno = new frmBusquedaDeAlumno();
            buscarAlumno.Show();
        }
    }
}
