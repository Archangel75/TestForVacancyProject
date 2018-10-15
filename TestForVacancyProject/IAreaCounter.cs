using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForVacancyProject
{
    public interface IAreaCounter
    {
        object Count(List<object> paramList);
        double Area();
        void Extract(List<object> paramList);
    }

    public interface IFactChecker
    {
        bool Check();
    }
}
