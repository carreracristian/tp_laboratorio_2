﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        /// <summary>
        /// inicializamos la conexion y los comandos
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection(@"Data Source=LAPTOP-FMC2PDVS\SQLEXPRESS;Initial Catalog=EXACTO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = CommandType.Text;
            PaqueteDAO.comando.Connection = conexion;
        }

        /// <summary>
        /// Inserta un paquete en la BD
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            string comando = string.Format("INSERT INTO Paquetes(direccionEntrega,trackingID,alumno) VALUES('{0}','{1}','Carrera Cristian')", p.DireccionEntrega, p.TrackingID);
            try
            {
                PaqueteDAO.comando.CommandText = comando;
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                PaqueteDAO.conexion.Close();
            }

        }
    }
}

