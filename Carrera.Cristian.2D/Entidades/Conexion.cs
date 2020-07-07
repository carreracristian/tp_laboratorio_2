using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Archivos;
using Excepciones;

namespace Entidades
{
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        /// <summary>
        /// Creamos la conexion a la base de datos
        /// </summary>
        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=LAPTOP-FMC2PDVS\SQLEXPRESS;Initial Catalog=JardinUtn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                cn.Open();
                //MessageBox.Show("Se ha conectado a la base de datos", "Conectado");
            }
            catch (ConexionBaseDeDatosException e)
            {
                MessageBox.Show("No se pudo conectar:" + e.ToString());
                GuardarErrores(e.Message);
            }
        }
        /// <summary>
        /// Obtenemos los datos de los docentes de un archivo xml y los cargamos a la base de datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        public string InsertarDocentesXml(string nombre, string apellido, int edad, string sexo, int dni, string direccion, string mail)
        {
            string salida = "Docente ingresado correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Docentes(Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) values('" + nombre + "','" + apellido + "'," + edad + ",'" + sexo + "'," + dni + ",'" + direccion + "','" + mail + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (ConexionBaseDeDatosException e)
            {
                salida = "No se conecto: " + e.ToString();
                GuardarErrores(e.Message);
            }
            return salida;
        }
        /// <summary>
        /// Guardamos las evaluaciones en la base de datos
        /// </summary>
        /// <param name="e"></param>
        public void GuardarEvaluaciones(Evaluacion e)
        {
            string salida = "Evaluacion ingresada correctamente";
            try
            {
                cmd = new SqlCommand("Insert into Evaluaciones(idAlumno,idDocente,idAula,Nota_1,Nota_2,NotaFinal,Observaciones) values(" + e.IdAlumno + "," + e.IdDocente + "," + e.IdAula + "," + e.Nota1 + "," + e.Nota2 + "," + e.NotaFinal + ",'" + e.Observaciones + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (ConexionBaseDeDatosException ex)
            {
                salida = "No se conecto: " + ex.ToString();
                GuardarErrores(ex.Message);
            }
        }
        /// <summary>
        /// Verificamos que no se ingresen docentes ya existentes en la base de datos
        /// </summary>
        /// <param name="documento"></param>
        /// <returns></returns>
        public bool DocenteRegistrado(int documento)
        {
            int cont = 0;
            try
            {
                cmd = new SqlCommand("Select * from Docentes where Dni =" + documento + "", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cont++;
                }
                dr.Close();
            }
            catch (ConexionBaseDeDatosException e)
            {
                MessageBox.Show("No se pudo consultar: " + e.ToString());
                GuardarErrores(e.Message);
            }
            return cont != 0;
        }
        /// <summary>
        /// Obtenemos los alumnos de la base de datos y los almacenamos en una cola
        /// </summary>
        /// <returns></returns>
        public Queue<Alumno> ObtenerAlumnos()
        {
            Queue<Alumno> alumnos = new Queue<Alumno>();
            Alumno a;

            cmd = new SqlCommand("Select * FROM Alumnos", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    int id = int.Parse(dr["idAlumnos"].ToString());
                    string nombre = dr["Nombre"].ToString();
                    string apellido = dr["Apellido"].ToString();
                    int edad = int.Parse(dr["Edad"].ToString());
                    int dni = int.Parse(dr["Dni"].ToString());
                    string direccion = dr["Direccion"].ToString();
                    string responsable = dr["Responsable"].ToString();
                    a = new Alumno(id, responsable, nombre, apellido, edad, dni, direccion);

                    alumnos.Enqueue(a);
                }
            }
            catch (ConexionBaseDeDatosException e)
            {
                MessageBox.Show(e.Message);
                GuardarErrores(e.Message);
            }
            finally
            {
                dr.Close();
            }

            return alumnos;
        }
        /// <summary>
        /// Obtenemos los datos de las aulas de la base de datos y las guardamos en una lista
        /// </summary>
        /// <returns></returns>
        public List<Aula> ObtenerAulas()
        {
            List<Aula> aulas = new List<Aula>();
            Aula a;

            cmd = new SqlCommand("Select * FROM Aulas", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    int id = int.Parse(dr["idAula"].ToString());
                    string salita = dr["Salita"].ToString();

                    a = new Aula(id, salita);

                    aulas.Add(a);
                }
            }
            catch (ConexionBaseDeDatosException e)
            {
                MessageBox.Show(e.Message);
                GuardarErrores(e.Message);
            }
            finally
            {
                dr.Close();
            }

            return aulas;
        }
        /// <summary>
        /// Obtenemos los docentes de la base de datos y los guardamos en una lista
        /// </summary>
        /// <returns></returns>
        public List<Docente> ObtenerDocentes()
        {
            List<Docente> docentes = new List<Docente>();
            Docente d;

            cmd = new SqlCommand("Select * FROM Docentes", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string nombre = dr["Nombre"].ToString();
                    string apellido = dr["Apellido"].ToString();
                    int edad = int.Parse(dr["Edad"].ToString());
                    string sexo = dr["Sexo"].ToString();
                    int dni = int.Parse(dr["Dni"].ToString());
                    string direccion = dr["Direccion"].ToString();
                    string mail = dr["Email"].ToString();
                    int id = int.Parse(dr["idDocente"].ToString());


                    d = new Docente(id, apellido, nombre, edad, sexo, dni, direccion, mail);

                    docentes.Add(d);
                }
            }
            catch (ConexionBaseDeDatosException e)
            {

                MessageBox.Show(e.Message);
                GuardarErrores(e.Message);
            }
            finally
            {
                dr.Close();
            }

            return docentes;
        }
        /// <summary>
        /// Mostramos los docentes de la base de datos en el formulario principal
        /// </summary>
        /// <returns></returns>
        public object MostrarDocentes()
        {
            DataTable tabla = new DataTable();


            cmd = new SqlCommand("Select * FROM Docentes", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            tabla.Load(dr);
            return tabla;
        }
        /// <summary>
        /// Mostramos los alumnos de la base de datos en el formulario principal
        /// </summary>
        /// <returns></returns>
        public object MostrarAlumnos()
        {
            DataTable tabla = new DataTable();


            cmd = new SqlCommand("Select * FROM Alumnos", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            tabla.Load(dr);
            return tabla;
        }
        /// <summary>
        /// Mostramos las aulas de la base de datos en el formulario secundario
        /// </summary>
        /// <returns></returns>
        public object MostrarAulas()
        {
            DataTable tabla = new DataTable();

            cmd = new SqlCommand("Select * FROM Aulas", cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            tabla.Load(dr);
            return tabla;
        }
        /// <summary>
        /// Guardamos los errores surgidos en un archivo de texto
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool GuardarErrores(string message)
        {
            try
            {
                string ruta = System.IO.Directory.GetCurrentDirectory() + @"\Archivos";
                System.IO.Directory.CreateDirectory(ruta);

                Texto txt = new Texto();

                txt.Guardar((ruta + @"\Errores.txt"), message);
                return true;
            }
            catch (ErrorDirectorioException e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
