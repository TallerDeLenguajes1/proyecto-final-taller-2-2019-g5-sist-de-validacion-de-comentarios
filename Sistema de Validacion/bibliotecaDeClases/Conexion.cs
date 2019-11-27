using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows;

namespace PruebaConexion
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=Taller2;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(int id, string nombre, string apellidos, string fecha)
        {
            string salida = "Registro Agregado Con éxito";
            try
            {
                cmd = new SqlCommand("Insert into Alumnos(Id_Alumno,Nombre,Apellido) values(" + id + ",'" + nombre + "','" + apellidos + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string modificar(int id, string nombre, string apellidos, string fecha)
        {
            string salida = "Registro modificado Con éxito";
            try
            {
                cmd = new SqlCommand("update Alumnos set Nombre='" + nombre + "',Apellido='" + apellidos + "' where id_Alumno=" + id, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string borrar(int id)
        {
            string salida = "Registro Borrado Con éxito";
            try
            {
                cmd = new SqlCommand("Delete from Alumnos where id_Alumno=" + id, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }



        public int AlumnoRegistrado(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Alumnos where Id_Alumno=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }



    }
}
