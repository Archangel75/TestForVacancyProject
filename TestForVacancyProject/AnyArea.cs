﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestForVacancyProject
{
    public class AnyArea : BaseAreaCounter, IAreaCounter
    {
        ///<summary>
        ///<para> Возвращает площадь произвольной фигуры.</para>
        ///</summary>
        public double Area()
        {
            double area = default(double);

            for (int i = 0; i < dots.Length - 1; i++)
            {
                area += dots[i].X * dots[i + 1].Y - dots[i + 1].X * dots[i].Y;
            }
            area += dots[dots.Length - 1].X * dots[0].Y - dots[dots.Length - 1].Y * dots[0].X;

            return Math.Round(Math.Abs(area / 2), 2);
        }
    }
}
