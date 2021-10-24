using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Windows.Forms;

namespace Datos
{
    public class DatosDocentes : DatosConexionBD
    {
        public int abmDocentes(string accion, Docente objDocente)
        {
            int resultado = -1;
            int edad = objDocente.FechNac.Year;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "Insert into Docente values (@Nombre, @Dni,@Fecha,@Edad,@Sexo,@Legajo,@Materia);";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Nombre", objDocente.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objDocente.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objDocente.FechNac);
                    cmd.Parameters.AddWithValue("@Edad", objDocente.Edad(edad));
                    cmd.Parameters.AddWithValue("@Sexo", objDocente.Sexo);
                    cmd.Parameters.AddWithValue("@Materia", objDocente.Materia);
                    cmd.Parameters.AddWithValue("@Legajo", objDocente.Legajo);
                    
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("El Dni ingresado ya existe en la tabla", "Error");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Baja")
            {
                orden = "delete from Docente where Dni ='" + objDocente.Dni.ToString() + "';";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Modificar")
            {

                orden = "Update Docente set Nombre = @Nombre, [Fecha-de-nacimiento] = @Fecha, Edad =@Edad, Sexo= @Sexo, Legajo= @Legajo,Materia=@Materia where Dni = @Dni";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Nombre", objDocente.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objDocente.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objDocente.FechNac.Date);
                    cmd.Parameters.AddWithValue("@Edad", objDocente.Edad(edad));
                    cmd.Parameters.AddWithValue("@Sexo", objDocente.Sexo);
                    cmd.Parameters.AddWithValue("@Legajo", objDocente.Legajo);
                    cmd.Parameters.AddWithValue("@Materia", objDocente.Materia);                    

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
            }

            return resultado;
        }

        public DataSet listadoDocentes(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Docente;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Docentes", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
