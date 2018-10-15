using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public interface IAreaCounter
    {
        double Area(List<object> paramList);
        void Extract(List<object> paramList);
    }
}
