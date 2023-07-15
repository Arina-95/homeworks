// // Задача 54: 
// // Задайте двумерный массив. Напишите программу, которая упорядочит 
// // по убыванию элементы каждой строки двумерного массива.


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
//             System.Console.Write(array[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void MaxToMin (int[,]array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1) - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if(array[k,j]> array[k, maxPosition]) maxPosition = j;
//         }
//         int temp = array[k, i];
//         array[k, i] = array[k, maxPosition];
//         array[k, maxPosition] = temp;
//     }
//     }
// }


// int[,] myArray = Create2DArray(5,5,1,100);
// Print2DArray(myArray);
// System.Console.WriteLine();
// MaxToMin(myArray);
// Print2DArray(myArray);



// // Задача 56: 
// // Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

// int[] RowsSum(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//     }
//     return sum;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(array[i] + " ");
//     }
// }

// void FindMin(int[] array)
// {
//     int size = array.Length;
//     int min = 1000;
//     int row = 0;

//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             row = i;
//         }
//     }
//     System.Console.WriteLine($"строка с наименьшей суммой элементов ({min}) - это строка номер {row + 1}!");

// }

// int[,] myArray = Create2DArray(7, 5, 1, 9);
// Print2DArray(myArray);
// System.Console.WriteLine();
// PrintArray(RowsSum(myArray));
// System.Console.WriteLine();
// FindMin(RowsSum(myArray));


// // Задача 58: 
// // Задайте две матрицы. Напишите программу, 
// // которая будет находить произведение двух матриц.

// int [,] Array1 = new int [2,2]
// {
//     {1,2},
//     {8,3},
// };

// int [,] Array2 = new int [2,2]
// {
//     {4,2},
//     {7,5},
// };

// Print2DArray(Array1);
// Print2DArray(Array2);


// int[,] MatxMultipl (int [,] array1, int [,] array2)
// {
//     int [,] result = new int [2,2];    
//     result[0,0] = array1[0,0] * array2[0,0] + array1[0,1] * array2[1,0];
//     result[0,1] = array1[0,0] * array2[0,1] + array1[0,1] * array2[1,1];
//     result[1,0] = array1[1,0] * array2[0,0] + array1[1,1] * array2[1,0];
//     result[1,1] = array1[1,0] * array2[0,1] + array1[1,1] * array2[1,1];
//     return result;
// }

// Print2DArray(MatxMultipl(Array1,Array2));

// // Задача 60.
// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// // которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Create3DArray (int rows, int colums, int third, int minV, int maxV)
// {
//     int[,,] array = new int[rows, colums, third];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             for (int h = 0; h < third; h++)
//             {
//                 array[i, j, h] = new Random().Next(minV, maxV + 1);
//             }
            
//         }
//     }
//     return array;
// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int h = 0; h < array.GetLength(2); h++)
//             {
//                 System.Console.Write($"{array[i, j, h]}({i},{j},{h})   " );
//             }
//             System.Console.WriteLine();
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// Print3DArray(Create3DArray(3,3,3,10,99));


// // Задача 62. 
// // Напишите программу, которая заполнит спирально массив 4 на 4.

// void Print2DSpiralArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] <= 9)
//             {
//                 System.Console.Write($"0{array[i, j]} ");
//             }
//             else
//             {
//                 System.Console.Write(array[i, j] + " ");

//             }

//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int[,] Fill2DSpiralArray()
// {
//     int[,] array = new int[4, 4];
//     int i = 0;
//     int j = -1;
//     int m = 1;
//     while (m <= 16)
//     {
//         if (m<= 4)
//         {
//             j++;
//             array[i, j] = m;
//             m++;

//         }
//         else
//         {
//             if (m <= 7)
//             {
//                 i++;
//                 array[i, j] = m;
//                 m++;

//             }
//             else 
//             {
//                 if(m <= 10)
//                 {
//                     j--;
//                     array[i,j] = m;
//                     m++;
//                 }
//                 else 
//                 {
//                     if (m <= 12)
//                     {
//                         i--;
//                         array[i,j] = m;
//                         m++;
//                     }
//                     else 
//                     {
//                         if (m <= 14)
//                         {
//                             j++;
//                             array[i,j] = m;
//                             m++;
//                         }
//                         else 
//                         {
//                             if (m<=15)
//                             {
//                                 i++;
//                                 array[i,j] = m;
//                                 m++;
//                             }
//                             else
//                             {
//                                j--;
//                                array[i,j] = m;
//                                m++;
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//     }
//         return array;
//     }

//     Print2DSpiralArray(Fill2DSpiralArray());