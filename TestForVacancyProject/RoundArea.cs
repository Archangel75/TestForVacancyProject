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
        ///<summary>
        ///<para> Возвращает площадь круга.</para>
        ///</summary>
        public double Area(List<object> paramList)
        {
            Extract(paramList);
            return Math.Round(Math.Pow(Convert.ToDouble(radius), 2) * 3.1415, 2);
        } 

        public void Extract(List<object> paramList)
        {
            Double.TryParse(paramList.First().ToString(), out radius);
        }
    }


}
