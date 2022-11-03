using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Rectangle
    {
        public double[,] points;

        public Rectangle(double[,] points)
        {
            this.points = new double[points.GetLength(0), points.GetLength(1)];
            Array.Copy(points, destinationArray: this.points, points.Length);
        }

        public void Move(double x, double y)
        {
            if (points.GetLength(1) == 2)
                for (int i = 0; i < points.GetLength(0); i++)
                {
                    points[i, 0] += x;
                    points[i, 1] += y;
                }
        }

        public void Print()
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    Console.WriteLine(points[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
