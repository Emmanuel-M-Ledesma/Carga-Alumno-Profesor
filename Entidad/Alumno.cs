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
        private long DNI;
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

        public long DNI2
        {
            get { return DNI; }
            set { DNI = value; }
        }
        #endregion


        #region Constructores
        public Alumno() 
        { 
        }
        public Alumno(string Nom, long Du, DateTime FecNac, char Sex, string Carr, string Leg, long DNI) : base(Nom, Du, FecNac, Sex)
        {
            Carrera = Carr;
            Legajo = Leg;
            DNI2 = DNI;
        }
        #endregion

        #region Metodos

        

        #endregion
    }
}