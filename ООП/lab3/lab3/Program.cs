
using lab3;
using System;
using System.Security.Claims;

namespace lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			double[,] array1 = { { 2, 0, -1 }, { 0, -2, 2 } };
            double[,] array2 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
            double[,] array3 = { { 5, 3, 1 }, { 2, 1, 3 }, { 5, 4, 1 } };

            var matrix1 = new Matrix(array1);
			var matrix2 = new Matrix(array2);
			var matrix3 = new Matrix(array3);

			matrix1.ConsolePrint();
			Console.WriteLine();
			matrix2.ConsolePrint();
			Console.WriteLine();
			matrix3.ConsolePrint();

			Console.WriteLine("-----------------------");

			Console.WriteLine(matrix1.GetHiherValuesNumber(3.15).ToString() + " " + matrix2.GetHiherValuesNumber(3.15).ToString());

            Console.WriteLine("-----------------------");

            (matrix1 * matrix2).ConsolePrint();
			Console.WriteLine();
			(matrix2 * matrix3).ConsolePrint();

            Console.WriteLine("-----------------------");

            if (matrix1.GetHiherValuesNumber(0, 2) == matrix2.GetHiherValuesNumber(0, 3))
			{
				double[] doubles1 = matrix1;
				double[] doubles2 = matrix2;
				foreach (var element in doubles1) Console.Write(element + " ");
				Console.WriteLine();
                foreach (var element in doubles2) Console.Write(element + " ");
            } else
			{
				double[] doubles3 = matrix3;
                foreach (var element in doubles3) Console.Write(element + " ");
            }
		}
	}
}