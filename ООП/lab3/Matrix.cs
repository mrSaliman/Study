using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Matrix
    {
        private double[,] matrix;

        public Matrix(int rows, int columns)
        {
            this.matrix = new double[rows, columns];
        }

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }   

        public void ChangeMatrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }
        public int Columns
        {
            get { return matrix.GetLength(1); }
        }

        public double this[int row, int column]
        {
            get => matrix[row, column];
            set => matrix[row, column] = value;
        }

        public void ConsolePrint()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        public void WriteMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент {i}-й строки {j}-го ряда: ");
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
        }

        public int GetHiherValuesNumber(double value)
        {
            int result = 0;
            foreach (var element in matrix)
                if (element > value) result++;
            return result;
        }

        public int GetHiherValuesNumber(double value, int multiplicity)
        {
            int result = 0;
            for (int j = multiplicity; j < matrix.GetLength(1); j+= multiplicity)
                for (int i = 0; i < matrix.GetLength(0); i++)
                    if (matrix[i,j] > value) result++;
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Matrix) return false;
            Matrix matrix = (Matrix)obj;
            if (matrix.Columns != this.Columns || matrix.Rows != this.Rows) return false;
            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Columns; j++)
                    if (matrix[i,j] != this[i,j]) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(matrix);
        }

        public static Matrix operator *(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.Columns != matrixB.Rows) return new Matrix(0, 0);
            double[,] result = new double[matrixA.Rows, matrixB.Columns];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    for (int k = 0; k < matrixA.Columns; k++) result[i,j] += matrixA[i,k] * matrixB[k, j];
            return new Matrix(result);
        }

        public static implicit operator double[](Matrix matrix)
        {
            double[] result = new double[matrix.Rows];
            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++) result[i] += matrix[i,j];
            return result;
        }


    }
}
