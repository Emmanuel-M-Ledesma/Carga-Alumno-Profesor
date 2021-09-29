using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class DatosConexionBD
    {

        #region Atributos

        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-06KE21D\SQLSERVEREXPRESS;Initial Catalog=CargaAP;Integrated Security=True";

        #endregion

        #region Constructor

        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        #endregion

        #region Metodos

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }

        #endregion

        public void SaveAlumno(string nom, string dni, DateTime fech, int edad, char sex, string leg, string car)
        {
            AbrirConexion();
            SqlCommand guardar = new SqlCommand("insert into Alumnos values(@Nombre,@Dni,@Fecha,@Edad,@Sexo,@Legajo,@Carrera)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Nombre", nom);
                guardar.Parameters.AddWithValue("@Dni", dni);
                guardar.Parameters.AddWithValue("@Fecha", fech);
                guardar.Parameters.AddWithValue("@Edad", edad);
                guardar.Parameters.AddWithValue("@Sexo",Convert.ToChar( sex));
                guardar.Parameters.AddWithValue("@Legajo", leg);
                guardar.Parameters.AddWithValue("@Carrera", car);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }       

        public void SaveDocente(string nom, string dni, DateTime fech, int edad, string sex, string leg, string mat)
        {
            AbrirConexion();
            SqlCommand guardar = new SqlCommand("insert into Docente values(@Nombre,@Dni,@Fecha,@Edad,@Sexo,@Legajo,@Materia)", conexion);

            try
            {

                guardar.Parameters.Clear();
                guardar.Parameters.AddWithValue("@Nombre", nom);
                guardar.Parameters.AddWithValue("@Dni", dni);
                guardar.Parameters.AddWithValue("@Fecha", fech);
                guardar.Parameters.AddWithValue("@Edad", edad);
                guardar.Parameters.AddWithValue("@Sexo", Convert.ToChar(sex));
                guardar.Parameters.AddWithValue("@Legajo", leg);
                guardar.Parameters.AddWithValue("@Materia", mat);
                guardar.ExecuteNonQuery();


            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
        
        public void Delete(string dni, DataGridView dgv, string cadenaA, string cadenaB)
        {
            AbrirConexion();
            
            if (cadenaA == "delete from Alumnos where Dni = (@Dni)")
            {
                SqlCommand Borrar = new SqlCommand(cadenaA, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                SqlCommand Borrar= new SqlCommand(cadenaB, conexion);
                try
                {
                    int posicion = dgv.CurrentRow.Index;
                    Borrar.Parameters.Clear();
                    Borrar.Parameters.AddWithValue("@Dni", dgv[1, posicion].Value.ToString());
                    Borrar.ExecuteNonQuery();
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            
        }
        
    }
}
