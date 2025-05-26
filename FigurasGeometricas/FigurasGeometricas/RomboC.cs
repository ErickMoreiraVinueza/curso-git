using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class RomboC
    {
        private double diagonalMayor;
        private double diagonalMenor;
        private double lado;
        public double DiagonalMayor => diagonalMayor;
        public double DiagonalMenor => diagonalMenor;

        public RomboC(double diagonalMayor, double diagonalMenor, double lado)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}
