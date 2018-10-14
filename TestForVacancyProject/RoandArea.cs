using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public class RoundArea : BaseAreaCounter, IAreaCounter
    {
        ///<summary>
        ///<para> Возвращает площадь круга.</para>
        ///</summary>
        public double Area() => Math.Round(Math.Pow(Convert.ToDouble(radius), 2) * 3.1415, 2);
    }
}
