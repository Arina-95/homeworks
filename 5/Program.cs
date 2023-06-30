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


// void FindNegSum (int[] array)
// {
//     int negSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]<0) negSum += array[i];
//     }
// System.Console.WriteLine($"Сумма отрицательных чисел -> {negSum}");
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
// FindNegSum(myArray);

// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateRandomArray(int size, double minV, double maxV)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        double one = new Random().Next(minV, maxV + 1);
        double two = new Random().NextDouble;
        double sum = one + two;
        array[i] = sum;
    }
    return array;
}

void PrintRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

System.Console.WriteLine("Введите размер массива -> ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число массива -> ");
double minV = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число массива -> ");
double maxV = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, minV, maxV);
PrintRandom(myArray);
System.Console.WriteLine();
