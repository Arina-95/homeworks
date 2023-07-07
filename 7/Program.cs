// // Задача 47. 
// // Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.

// double[,] CreateDouble2DArray(int rows, int colums, int minV, int maxV)
// {
//     double[,] array = new double[rows, colums];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = Math.Round ((rand.Next(minV, maxV + 1) + rand.NextDouble()),2);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Введите количество строк -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов -> ");
// int colums = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение массива -> ");
// int minV = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива -> ");
// int maxV = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateDouble2DArray(rows,colums,minV,maxV);
// Print2DArray(myArray);



// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DArray(int rows, int colums, int minV, int maxV)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minV, maxV + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }



// void WhatIsTheNum (int[,]array, int x, int y)
// {
//     int num = 0;
//     if(x >= array.GetLength(0) || y >= array.GetLength(1) || x < 0 || y < 0)
//     {
//         System.Console.WriteLine($"Под координатами {x} * {y} нет числа, вы вышли за пределы массива:()");
//     }
//     else
//     {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if ( i==x && j==y)
//             {
//                 System.Console.WriteLine($"Под координатами {x} * {y} находиться число {array[i,j]}");
//             }
//         }
//     }
//     }
// }

// System.Console.WriteLine("Введите количество строк -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов -> ");
// int colums = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение массива -> ");
// int minV = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива -> ");
// int maxV = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату для поиска по массиву X -> ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату для поиска по массиву Y -> ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] intArray = Create2DArray(rows,colums,minV,maxV);
// Print2DArray(intArray);
// WhatIsTheNum(intArray,x,y);



// // Задача 52. 
// // Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DArray(int rows, int colums, int minV, int maxV)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minV, maxV + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// double[] ColumsArithSum (int[,] array)
// {
//     double [] sum = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i <= array.GetLength(0); i++)
//         {
            
//             if(i==array.GetLength(0))
//             {
//                 sum[j] = Math.Round ((sum[j]/i),2);
//             }
//             else
//             {
//                 sum[j] += array [i,j];
//             }
//         }
//     }
//     return sum;
// }

// void PrintArray (double[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.WriteLine("Введите количество строк -> ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов -> ");
// int colums = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение массива -> ");
// int minV = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива -> ");
// int maxV = Convert.ToInt32(Console.ReadLine());

// int[,] intArray = Create2DArray(rows,colums,minV,maxV);
// Print2DArray(intArray);
// PrintArray(ColumsArithSum(intArray));
