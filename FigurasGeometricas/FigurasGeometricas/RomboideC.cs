using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class RomboideC
    {
        private double baseRomboide;
        private double altura;
        private double ladoLateral;

        public double Base => baseRomboide;
        public double Altura => altura;
        public double LadoLateral => ladoLateral;


        public RomboideC(double baseRomboide, double altura, double ladoLateral)
        {
            this.baseRomboide = baseRomboide;
            this.altura = altura;
            this.ladoLateral = ladoLateral;
        }

        public double CalcularArea()
        {
            return baseRomboide * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (baseRomboide + ladoLateral);
        }
    }
}
