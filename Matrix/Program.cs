using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(3);
            matrix.SetElement(0, 0, 1);
            matrix.SetElement(0, 1, 2);
            matrix.SetElement(0, 2, 3);

            Console.WriteLine("Matrix elements:");
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    Console.Write(matrix.GetElement(i, j) + " ");
                }
                Console.WriteLine();
            }
            int value = matrix.GetElement(0, 1);
            Console.WriteLine(value);
        }
    }
    public class Matrix<T>
    {
        private T[,] elements;
        public int Size { get; set; }
        public Matrix(int size)
        {
            Size = size;
            elements = new T[size, size];
        }
        public void SetElement(int row, int column, T value)
        {
            elements[row, column] = value;
        }
        public T GetElement(int row, int column)
        {
            return elements[row, column];
        }
    }
}
