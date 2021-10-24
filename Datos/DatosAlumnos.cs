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
    public class DatosAlumnos : DatosConexionBD
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            int edad = objAlumno.FechNac.Year;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = "Insert into Alumnos values (@Nombre, @Dni,@Fecha,@Edad,@Sexo,@Legajo,@Carrera);";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Nombre",objAlumno.Nombre );
                    cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objAlumno.FechNac.Date); 
                    cmd.Parameters.AddWithValue("@Edad", objAlumno.Edad(edad));
                    cmd.Parameters.AddWithValue("@Sexo", objAlumno.Sexo);
                    cmd.Parameters.AddWithValue("@Legajo", objAlumno.Legajo);
                    cmd.Parameters.AddWithValue("@Carrera", objAlumno.Carrera);
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception )
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
                orden = "delete from Alumnos where Dni ='"+ objAlumno.Dni.ToString()+"';";
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
                
                orden = "Update Alumnos set Nombre = @Nombre, [Fecha-de-nacimiento] = @Fecha, Edad =@Edad, Sexo= @Sexo, Legajo= @Legajo, Carrera=@Carrera where Dni = @Dni" ;
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
                    cmd.Parameters.AddWithValue("@Fecha", objAlumno.FechNac.Date);
                    cmd.Parameters.AddWithValue("@Edad", objAlumno.Edad(edad));
                    cmd.Parameters.AddWithValue("@Sexo", objAlumno.Sexo);
                    cmd.Parameters.AddWithValue("@Legajo", objAlumno.Legajo);
                    cmd.Parameters.AddWithValue("@Carrera", objAlumno.Carrera);                    

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

        public DataSet listadoAlumnos(string todos)
        {
            string orden = string.Empty;
            orden = "select * from Alumnos;";
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

                throw new Exception("Error al listar Alumnos", e);
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
