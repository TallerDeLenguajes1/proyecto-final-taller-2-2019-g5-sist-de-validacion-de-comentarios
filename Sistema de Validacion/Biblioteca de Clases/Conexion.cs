using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Biblioteca_de_Clases
{
    public class Conexion
    {
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=carde2296;Database=taller;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public void insertar(string nombre, string contrasenia, string ciudad)
        {
            string salida = "No se pudo agregar el registro";
            try
            {
                int idCiudad = 0;

                cmd = new MySqlCommand("Select idciudad from ciudad where nombre='" + ciudad + "'", cn);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        idCiudad = dr.GetInt32(0);
                    }
                }

                dr.Close();

                cmd = new MySqlCommand("Insert into tusuario(tusuario, tcontrasenia, idciudad) values('" + nombre + "','" + contrasenia + "'," + idCiudad + ")", cn);
                cmd.ExecuteNonQuery();

                salida = "Registro Agregado Con éxito";
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            MessageBox.Show(salida);
        }

        public void InsertarEmpresa(string nombre, string razon, string rubro)
        {
            string salida = "No se pudo agregar el registro";

            try
            {
                cmd = new MySqlCommand("Insert into tempresas(nombre, razon, rubro) values('" + nombre + "','" + razon + "', '" + rubro + "')", cn);
                cmd.ExecuteNonQuery();

                salida = "Registro Agregado Con éxito";
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            MessageBox.Show(salida);
        }

        public void InsertarComentario(string comentario, string empresa, string nombreUsuario)
        {
            string salida = "No se pudo agregar el registro";

            try
            {
                int idEmpresa = 0;

                cmd = new MySqlCommand("Select idempresas from tempresas where nombre='" + empresa + "'", cn);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idEmpresa = dr.GetInt32(0);
                    }
                }

                dr.Close();



                int idUsuario = 0;

                cmd = new MySqlCommand("Select idtusuario from tusuario where tusuario='" + nombreUsuario + "'", cn);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idUsuario = dr.GetInt32(0);
                    }
                }

                dr.Close();


                cmd = new MySqlCommand("Insert into tcomentarios(contenido, validez, idempresa, idusuario) values('" + comentario + "', 0 ," + idEmpresa + ", " + idUsuario + ")", cn);
                cmd.ExecuteNonQuery();

                salida = "Registro Agregado Con éxito";
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            MessageBox.Show(salida);
        }

        public string[] SelecionarComentarios(int validez, string empresa)
        {
            string[] filas = new string[7];

            string pais = null;

            try
            {
                cmd = new MySqlCommand("Select contenido from tcomentarios where validez=" + validez, cn);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        pais = dr.GetString(0);

                        filas[i] = pais.ToString();

                        i++;
                    }

                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }

            return filas;
        }

        public string modificar(int id, string nombre, string apellidos, string fecha)
        {
            string salida = "Registro modificado Con éxito";
            try
            {
                cmd = new MySqlCommand("update Alumnos set Nombre='" + nombre + "',Apellido='" + apellidos + "' where id_Alumno=" + id, cn);
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
                cmd = new MySqlCommand("Delete from Alumnos where id_Alumno=" + id, cn);
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
                cmd = new MySqlCommand("Select * from Alumnos where Id_Alumno=" + id + "", cn);
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

        public int Logeo(string usuario, string contrasenia)
        {
            int respuesta = 0;

            try
            {
                cmd = new MySqlCommand("Select tusuario, tcontrasenia from tusuario where tusuario='" + usuario + "' and tcontrasenia='" + contrasenia +"'", cn);

                dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    respuesta = 1;
                }

                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }

            return respuesta;
        }

        public string[] ConsultaGeneral(string sql)
        {
            string[] filas = new string[7];

            string pais = null;

            try
            {
                cmd = new MySqlCommand("Select nombre from "+ sql, cn);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        pais =  dr.GetString(0) ;

                        filas[i] = pais.ToString();

                        i++;
                    }

                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }

            return filas;
        }
    }
}
