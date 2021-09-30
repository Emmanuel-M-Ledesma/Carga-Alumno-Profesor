using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Alumno : Persona 
    {
        private string carrera;
        private string legajo;

        #region Propiedades
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        #endregion


        #region Constructores
        public Alumno() 
        { 
        }
        public Alumno(string Nom, long Du, DateTime FecNac, char Sex, string Carr, string Leg) : base(Nom, Du, FecNac, Sex)
        {
            Carrera = Carr;
            Legajo = Leg;

        }
        #endregion

        #region Metodos

        

        #endregion
    }
}