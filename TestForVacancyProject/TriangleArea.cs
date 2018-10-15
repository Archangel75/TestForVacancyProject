using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{

    public class TriangleArea :  IAreaCounter, IFactChecker
    {
        private double aSide = 0;
        private double bSide = 0;
        private double cSide = 0;
        private bool needCheck = false;

        public TriangleArea()
        {
        }

        public TriangleArea(bool needChecks)
        {
            needCheck = needChecks;
        }

        public object Count(List<object> paramList)
        {
            object result = null;

            if (paramList != null)
                Extract(paramList);

            result = Area();
            if (needCheck)
                return new Tuple<double, bool>((double)result, Check());

            return result;
        }

        public void Extract(List<object> paramList)
        {
            Double.TryParse(paramList.First().ToString(), out aSide);
            Double.TryParse(paramList[1].ToString(), out bSide);
            Double.TryParse(paramList[2].ToString(), out cSide);
        }

        public double Area()
        {

            double p = Perimeter();
            return Math.Round(Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide)), 2);
        }

        public bool Check()
        {
            if (!needCheck)
                return false;

            try
            {
                var leftSide = Math.Round(Math.Pow(aSide, 2), 1) + Math.Round(Math.Pow(bSide, 2), 1);
                var rightSide = Math.Round(Math.Pow(cSide, 2), 1);

                if (leftSide == rightSide)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private double Perimeter()
        {
            return (aSide + bSide + cSide) / 2;
        }
    }
}
