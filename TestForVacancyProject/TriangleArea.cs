using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public class TriangleArea : BaseAreaCounter, IAreaCounter
    {
        private double Perimeter()
        {
            return aSide + bSide + cSide;
        }

        ///<summary>
        ///<para> Возвращает площадь треугольника </para>
        ///</summary>
        public double Area()
        {
            double p = Perimeter();
            return Math.Round(Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide)), 2);
        }

    }
}
