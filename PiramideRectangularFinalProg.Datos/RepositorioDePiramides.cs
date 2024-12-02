using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Datos
{

    public class RepositorioDePiramides
    {
        private List<PiramideRegular> puntos;

        public RepositorioDePiramides()
        {
            puntos = new List<PiramideRegular>();
        }

        
        public bool AgregarPiramide(PiramideRegular piramide)
        {
            if (!puntos.Contains(piramide))
            {
                puntos.Add(piramide);
                return true;
            }
            return false;
        }

        
        public List<PiramideRegular> ObtenerPiramides()
        {
            return puntos;
        }
    }


}
