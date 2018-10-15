using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace TestForVacancyProject
{
    public class BaseAreaCounter
    {
        protected List<object> paramList { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns the result of counts or -1 if failed</returns>
        public double Count(List<object> ParamList)
        {
            paramList = ParamList;
            try
            {
                IAreaCounter counter = Resolve();
                
                return counter.Area(paramList);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return -1;
            }
        }

        private IAreaCounter Resolve()
        {
            try
            {
                if (paramList != null)
                {
                    if (paramList.Count == 3 && paramList.Any(x => x is double))
                        return new TriangleArea();
                    else if (paramList.Count == 1 && paramList.First() is double)
                        return new RoundArea();
                    else if (paramList.Count == 1 && paramList.First() is Point[])
                        return new AnyArea();
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
