using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Docente : Persona
    {
        #region Atributos

        private string materia;
        private string legajo;


        #endregion

        #region Propiedades

        public string Materia 
        {
            get { return materia; }
            set { materia = value; }

        } 
        public string Legajo
        {
            get { return legajo; }
            set { legajo =value; }
        }

        #endregion

        #region Constructores

        public Docente()
        {

        }
        
        public Docente(string Nom,long Dni, DateTime FecNac,Char Sex, string Mat, String Leg) : base(Nom, Dni, FecNac, Sex)
        {
            Materia = Mat;
            Legajo = Leg;

        }


        #endregion
    }
}
