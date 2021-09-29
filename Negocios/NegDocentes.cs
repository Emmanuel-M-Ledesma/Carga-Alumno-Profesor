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
    public class NegDocentes
    {
        DatosDocentes ObjDatosDocente = new DatosDocentes();

        public int abmDocentes(string accion, Docente ObjDocente)
        {
            return ObjDatosDocente.abmDocentes(accion, ObjDocente);
        }
        public DataSet listadoDocentes(string todo)
        {
            return ObjDatosDocente.listadoDocentes(todo);
        }

    }
}
