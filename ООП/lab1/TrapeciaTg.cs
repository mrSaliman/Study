using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class TrapeciaTg
    {
        public double LeftBorder, LeftY;
        public double RightBorder, RightY;
        public bool IsReal;

        public TrapeciaTg(double leftBorder, double rightBorder)
        {
            this.LeftBorder = leftBorder;
            this.RightBorder = rightBorder;
            this.LeftY = Math.Tan(leftBorder);
            this.RightY = Math.Tan(rightBorder);
            if ((rightBorder <= leftBorder) || (rightBorder - leftBorder >= Math.PI / 2) ||
                (LeftY <= 0) || (RightY <= 0) || (LeftY % (Math.PI / 2) < 1E-10) || (RightY % (Math.PI / 2) < 1E-10)) this.IsReal = false;
            else this.IsReal = true;
        }

        public double LeftSide()
        {
            if (IsReal) return LeftY;
            else return -1;
        }

        public double RightSide()
        {
            if (IsReal) return RightY;
            else return -1;
        }

        public double BottomSide()
        {
            if (IsReal) return RightBorder - LeftBorder;
            else return -1;
        }

        public double TopSide()
        {
            if (IsReal)
            {
                double sum = 0;
                double step = (RightBorder - LeftBorder) / 10000;
                for (double x = LeftBorder; x + step <= RightBorder; x += step)
                    sum += Math.Sqrt(Math.Pow(Math.Tan(x) - Math.Tan(x + step), 2) + step * step);
                return sum;
            }
            else return -1;
        }

        public double Perimeter()
        {
            if (IsReal)
            {
                return TopSide() + BottomSide() + LeftSide() + RightSide();
            }
            else return -1;
        }

        public double Square()
        {
            if (IsReal)
            {
                return Math.Log(Math.Abs(Math.Cos(LeftBorder))) - Math.Log(Math.Abs(Math.Cos(RightBorder)));
            }
            else return -1;
        }

        public bool Point(double x, double y)
        {
            if (x >= LeftBorder && x <= RightBorder && y >= 0 && y <= Math.Tan(x)) return true;
            else return false;
        }
    }
}
