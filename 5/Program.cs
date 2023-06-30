// Задача 34:
//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void PrintRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }


// void EvenNum(int[] array)
// {
//     int even = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (array[i] % 2 == 0)
//         {
//             even++;
//             i++;
//         }
//         else
//         {
//             i++;
//         }

//     }
//     System.Console.WriteLine($"В массиве {even} чётных чисел"); ;
// }

// System.Console.WriteLine("Введите размер массива -> ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minV, maxV);
// PrintRandom(myArray);
// System.Console.WriteLine();
// EvenNum(myArray);

// // Задача 36:
// //  Задайте одномерный массив, заполненный случайными числами. 
// //  Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minV, int maxV)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minV, maxV + 1);
//     }
//     return array;
// }

// void PrintRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }


// void FindOddPositionSum(int[] array)
// {
//     int oddPosSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) oddPosSum += array[i];
//     }
//     System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {oddPosSum}");
// }

// System.Console.WriteLine("Введите размер массива -> ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное число массива -> ");
// int minV = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное число массива -> ");
// int maxV = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minV, maxV);
// PrintRandom(myArray);
// System.Console.WriteLine();
// FindOddPositionSum(myArray);

// // Задача 38: 
// // Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] CreateRandomArray()
// {
//     double[] array = new double[5];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round ((rand.Next(1, 100) + rand.NextDouble()),2);
//     }
//     return array;
// }

// void PrintRandom(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " | ");
//     }
// }

// void DiffMaxMin (double[] array)
// {
//     double max = 0;
//     double min = 100 ;
//     double diff = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]> max) max = array[i];
//         if(array[i]< min) min = array[i];
//     }
//     diff = max - min;
//     System.Console.WriteLine($"разница между максимальным {max} и минимальным {min} элементом массива -> {diff}");
// }


// double[] myArray = CreateRandomArray();
// PrintRandom(myArray);
// System.Console.WriteLine();
// DiffMaxMin(myArray);