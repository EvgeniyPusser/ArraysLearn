﻿// //Console.Write($"\t1\t2\t3");
// Console.Write("Put size of Array  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] table1 = new int[n, n];

// for(int i = 0; i < n; i++){
//     Console.Write($"{i + 1}");
//     for (int j = 0; j < n; j++){
//       //Console.Write($"\t{table1[i, j]}");
//         table1[i, j] = new Random().Next(2, 90);
//         //(i + 1) * (j + 1);
//     }
//     Console.WriteLine();

// }

// for(int i = 0; i < n; i++){
//     Console.Write($"{i + 1}");
//     for (int j = 0; j < n; j++){
//       Console.Write($"\t{table1[i, j]}");
//        // table1[i, j] = (i + 1) * (j + 1);
//     }
//     Console.WriteLine();

// }

int[,] array =
 {

  {8,7,7},
  {8,12,10}
};
Console.WriteLine(array.GetLongLength(0));
Console.WriteLine(array.GetLongLength(1));
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

void Main()
{
    int[,] matrix = GenerateMatrix(8, 4, 0, 10);
    PrintMatrix(matrix);

    System.Console.WriteLine();
    double[] averages = GetRowAverage(matrix);
    PrintArray(averages);
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double[] GetRowAverage(int[,] matrix)
{
    double[] averageArray = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double temp = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i,j];
        }

        averageArray[i] = temp / matrix.GetLength(1);
    }

    return averageArray;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] myMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            myMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return myMatrix;
}

Main();