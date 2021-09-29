using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidad;

namespace Negocios
{
    public class NegAlumnos
    {
        DatosAlumnos objDatosAlumnos = new DatosAlumnos();


        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            return objDatosAlumnos.abmAlumnos(accion, objAlumno);
        }
        public DataSet listadoAlumnos(string todo)
        {
            return objDatosAlumnos.listadoAlumnos(todo);
        }
    }
}
