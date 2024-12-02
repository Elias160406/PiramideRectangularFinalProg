using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Entidades
{
    

    public class PiramideRegular
    {
       
        public int LadoBase { get; set; }
        public int Altura { get; set; }
        public Material Material { get; set; }

      
        public PiramideRegular(int ladoBase, int altura, Material material)
        {
            LadoBase = ladoBase;
            Altura = altura;
            Material = material;
        }
        public double AreaTotal
        {
            get
            {
                double areaBase = LadoBase * LadoBase;
                double areaLateral = (LadoBase * Altura) / 2;
                return areaBase + (4 * areaLateral);
            }
        }
        public double Volumen
        {
            get
            {
                return (AreaTotal * Altura) / 3;
            }
        }
        private int CalcularAreaBase()
        {
            return LadoBase * LadoBase;
        }

        
        private double CalcularAreaLateral()
        {
            return (LadoBase * Altura) / 2.0;
        }

        
        public double CalcularAreaTotal()
        {
            double areaBase = CalcularAreaBase();
            double areaLateral = CalcularAreaLateral();
            return areaBase + 4 * areaLateral;
        }

        
        public double CalcularVolumen()
        {
            double areaBase = CalcularAreaBase();
            return (areaBase * Altura) / 3.0;
        }
        public string InformarDatos()
        {
            return $"LadoBase: {LadoBase}Altura: {Altura}Material: {Material}";
}
}
}
