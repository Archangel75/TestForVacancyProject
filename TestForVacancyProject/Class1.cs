using System;
using System.Windows;

namespace TestForVacancyProject
{
    public class BaseAreaCounter
    {
        protected double aSide, bSide, cSide = 0;
        protected double radius = 0; 
        protected Point[] dots = null;

        public BaseAreaCounter()
        {

        }

        /// <summary>
        /// Constructor for counting triangle area
        /// </summary>
        /// <param name="a">a side</param>
        /// <param name="b">b side</param>
        /// <param name="c">c side</param>
        public BaseAreaCounter(double a, double b, double c)
        {
            aSide = a;
            bSide = b;
            cSide = c;
        }
        /// <summary>
        /// Constructor for counting round area
        /// </summary>
        /// <param name="Radius">Radius of the round</param>
        public BaseAreaCounter(double Radius)
        {
            radius = Radius;
        }
        /// <summary>
        /// Constructor for counting the area of unknown figure by the position of it`s vertices
        /// </summary>
        /// <param name="Dots">Point array of vertices coordinates</param>
        public BaseAreaCounter(Point[] Dots)
        {
            dots = Dots;
        }

        public double Count()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            IAreaCounter counter = null;
            if (radius > 0)
            {
                counter = new RoundArea();
            }
            else if (aSide > 0 && bSide > 0 && cSide > 0)
            {
                counter = new TriangleArea();
            }
            else if (dots != null)
            {
                counter = new AnyArea();
            }

            return counter.Area();
        }
    }
}
