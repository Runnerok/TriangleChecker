using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChecker
{
    public class Checker
    {
        public static string Check(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                double[] sides = { a, b, c };
                Array.Sort(sides);
                if (sides[2] < sides[0] + sides[1])
                {
                    if (Math.Pow(sides[2], 2) < Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) return "Остроугольный";
                    else if (Math.Pow(sides[2], 2) > Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) return "Тупоугольный";
                    else if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) return "Прямоугольный";
                }
                else return "Это не треугольник";
            }
            return "Стороны должны быть больше 0";
        }
    }
}
