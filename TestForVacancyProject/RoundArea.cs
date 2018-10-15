using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public class RoundArea : IAreaCounter
    {
        private double radius = 0;
        private bool needCheck = false;

        public object Count(List<object> paramList)
        {
            object result = null;

            if (paramList != null)
                Extract(paramList);

            result = Area();

            return result;
        }

        ///<summary>
        ///<para> Возвращает площадь круга.</para>
        ///</summary>
        public double Area()
        {
            return Math.Round(Math.Pow(Convert.ToDouble(radius), 2) * 3.1415, 2);
        }

        public void Extract(List<object> paramList)
        {
            Double.TryParse(paramList.First().ToString(), out radius);
        }
    }


}
