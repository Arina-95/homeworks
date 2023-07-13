// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void PrintNum(int n)
// {
//     if (n >= 1)
//     {
//         System.Console.Write(n + " ");
//         PrintNum(n - 1);
//     }
// }

// PrintNum(6);

// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int FindSumRec(int m, int n)
// {
//     if (m < n)
//     {
//        return FindSumRec(m + 1 , n) + m;
//     }
//     else
//     {
//         if (m > n)
//         {
//             return FindSumRec(m - 1, n) + m;
//         }
//         else return n;
//     }

// }

// System.Console.WriteLine(FindSumRec(10,5));

// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


// int Accerman (int n, int m)
// {
//     if (n==0)
//     {
//         return m + 1;
//     }
//     else
//     {
//         if ((n!=0) && (m==0))
//         {
//             return Accerman(n-1,1);
//         }
//         else return Accerman(n-1, Accerman(n,m-1));
//     }
// }

// System.Console.WriteLine(Accerman(1,2));