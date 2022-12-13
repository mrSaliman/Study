using Xunit.Sdk;
using lab3;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MatrixMultiplication()
        {
            double[,] array1 = { { 2, 0, -1 }, { 0, -2, 2 } };
            double[,] array2 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
            var matrix1 = new Matrix(array1);
            var matrix2 = new Matrix(array2);
            var actual = matrix1 * matrix2;
            double[,] result = { { 8, 1, 0 }, { -6, -2, -2 } };
            var expected = new Matrix(result);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ElementsNumberHigerThan2()
        {
            double[,] array2 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
            var matrix2 = new Matrix(array2);
            var actual = matrix2.GetHiherValuesNumber(2);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RowsSum()
        {
            double[,] array2 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
            var matrix2 = new Matrix(array2);
            double[] actual = matrix2;
            double[] expected = new double[3] { 5, 6, 1 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}