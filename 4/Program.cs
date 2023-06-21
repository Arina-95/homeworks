// // Задача 25: 
// // Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B.

// int Degree(int a, int b)
// {
//     int result = a;
//     int i = 1;
//     while (i < b)
//     {
//         result = result * a;
//         i ++;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число A -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите степень в которую вы хотите возвести заданное число -> ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Число {a} в {b} степени это -> {Degree(a,b)}");



// // Задача 27: 
// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfDigits (int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum = sum + n % 10;
//         n = n / 10; 
//     }
//     return sum;
// }

// System.Console.WriteLine("введите число -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Сумма всех цифр в числе {n} равна {SumOfDigits(n)}");



// // Задача 29: 
// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// void PrintRandomEightArray (int min, int max)
// {
//     int[] EightArray = new int [8];
//     for (int i = 0; i < EightArray.Length; i++)
//     {
//         EightArray[i] = new Random().Next(min, max);
//         System.Console.Write(EightArray[i] + " ");
//     }
// }

// System.Console.WriteLine("введите минимальное число -> ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("введите максимальное число -> ");
// int max = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// // System.Console.WriteLine("1 2 3 4 5 6 7 8");
// PrintRandomEightArray(min,max);
