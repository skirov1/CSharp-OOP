using System;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //double[] numbers = new double[n];

            //for (int i = 0; i < numbers.Length; i++ )
            //{
            //    numbers[i] = double.Parse(Console.ReadLine());
            //}

            //double oddSum = 0;

            //for (int i = 1; i < numbers.Length; i += 2)
            //{
            //    oddSum += numbers[i];
            //}
            //Console.WriteLine(oddSum);
            //Console.WriteLine(string.Join(", ", numbers));

            Console.Write("Enter n value: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m value: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,m];
            int min = int.MaxValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("Enter whole number: ");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    if (matrix[row,col] < min)
                    {
                        min = matrix[row, col];
                    }
                }
            }

            Console.Write("The min number in the matrix is: ");
            Console.WriteLine(min);
            Console.WriteLine("Matrix: ");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            int[,] newMatrix = new int[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row % 2 == 0)
                    {
                        newMatrix[row, col] = matrix[row, col] - 20;
                    }
                    else
                    {
                        newMatrix[row, col] = matrix[row, col] + 10;
                    }
                }               
            }





            for (int row = 0; row < newMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < newMatrix.GetLength(1); col++)
                {
                    Console.Write(newMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
