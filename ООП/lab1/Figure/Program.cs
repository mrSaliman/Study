using System;
using Figure;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Введите левую границу: ");
                double leftBorder = double.Parse(Console.ReadLine());
                Console.Write("Введите правую границу: ");
                double rightBorder = double.Parse(Console.ReadLine());
                TrapeciaTg tichon = new TrapeciaTg(leftBorder, rightBorder);
                if (!tichon.IsReal)
                {
                    Console.Clear();
                    Console.WriteLine("Такой трапеции не существует!!!");
                    continue;
                }
                Console.WriteLine($"Площадь фигуры: {tichon.Square()}");
                Console.WriteLine($"Периметр: {tichon.Perimeter()}");
                Console.WriteLine($"Стороны фигуры(верхняя, нижняя, левая, правая): " +
                    $"{tichon.TopSide()} {tichon.BottomSide()} {tichon.LeftSide()} {tichon.RightSide()}");
                Console.Write("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double y = double.Parse(Console.ReadLine());
                if (tichon.Point(x, y)) Console.WriteLine("Точка находится внутри или на самой трапеции.");
                else Console.WriteLine("Точка находится вне трапеции.");
                Console.ReadKey();
            }
        }
    }
}