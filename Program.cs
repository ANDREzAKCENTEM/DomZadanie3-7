// Знакомство с языками программирования (семинары)
// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     double[,] matrix = new double[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("  ");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ; ");
//             else Console.Write($"{matrix[i, j],3}  ");
//         }
//         Console.WriteLine("  ");
//     }
// }

// double[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
// PrintMatrix(array2D);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
//             else Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(array2D);

// Console.WriteLine("Укажите позиции элементов массива ");
// Console.WriteLine("элемент ряда: "); int rowElem = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("элемент столбца: "); int columnElem = Convert.ToInt32(Console.ReadLine());

// string GetElement(int[,] matrix, int row, int column)
// {
//     if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
//     {
//         return ($"{matrix[row, column]} ");
//     }
//     else
//     {
//         return "такого элемента в массиве нет";
//     }
// }
// string str = GetElement(array2D, rowElem, columnElem);
// Console.WriteLine($"{rowElem}, {columnElem} -> {str} ");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
//             else Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// double ColumnsValueSum(int[,] matrix)
// {
//     double sum = default;
//     double arithmeticMean = default;

// Console.Write("Среднее арифметическое каждого столбца:");

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     { 
//         if (j < matrix.GetLength(1))
//         {
//             sum = matrix[0, j] + matrix[1, j] + matrix[2, j];
//             arithmeticMean = Math.Round(sum / matrix.GetLength(0), 1); Console.Write($" {arithmeticMean}; ");
//         }
//     }
//     return arithmeticMean;
// }
// int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
// PrintMatrix(matr);

// Console.WriteLine();
// double columnSum = ColumnsValueSum(matr);
