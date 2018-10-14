using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public class TriangleArea :  IAreaCounter
    {
        private double aSide = 0;
        private double bSide = 0;
        private double cSide = 0;

        private double Perimeter()
        {
            return (aSide + bSide + cSide)/2;
        }

        ///<summary>
        ///<para> Возвращает площадь треугольника </para>
        ///</summary>
        public double Area(List<object> paramList)
        {
            Extract(paramList);
            double p = Perimeter();
            return Math.Round(Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide)), 2);
        }

        public void Extract(List<object> paramList)
        {
            Double.TryParse(paramList.First().ToString(), out aSide);
            Double.TryParse(paramList[1].ToString(), out bSide);
            Double.TryParse(paramList.Last().ToString(), out cSide);
        }
    }
}
