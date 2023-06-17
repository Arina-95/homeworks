Console.Clear();

// // Задача № 10
// /* Программа, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.*/

// System.Console.Write("Введите 3х значное число -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// void MinusSecondNumber(int n)
// {
//     if (n >= 100 && n <= 999)
//     {
//         System.Console.WriteLine($"Вторая цифра заданного трехзначного числа -> {(n / 10) % 10}");
//     }
//     else
//     {
//         System.Console.WriteLine($"Введено число не соответствующее условию");
//     }
// }

// MinusSecondNumber(n);



// // Задача № 13
// /* Программа, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.*/

// System.Console.Write("Введите любое число -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// void ThirdNumber(int n)
// {
// if (n >= 100 && n <= 999)
// {
//     System.Console.WriteLine($"Третья цифра заданного числа -> {n % 10}");
// }
// else
// {
//     if (n >= 1000 && n <= 9999)
//     {
//         System.Console.WriteLine($"Третья цифра заданного числа -> {(n % 100)/10}");
//     }
//     else
//     {
//         if (n <= 99) 
//         {
//             System.Console.WriteLine($"Третей цифры нет");
//         }
//         else
//         {
//             System.Console.WriteLine($"Пока не поняла, как вывести третью цифр 5, 6, 7 и далее знаков кроме как увеличивая if else, а в ответах решение неправильное");
//         }
//     }
// }
// }

// ThirdNumber(n);


// // Задача  15
// /*Программа, которая принимает на вход цифру, обозначающую
//  день недели, и проверяет, является ли этот день выходным.*/


// System.Console.Write("Введите цифру, обозначающаю день недели, который вы хотите проверить -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Является ли этот день выходным? -> ");

// void DayOfTheWeek(int n)
// {
//     if (n == 6 || n == 7)
//     {
//         System.Console.WriteLine("Да, это выходной");
//     }
//     else
//     {
//         if (n >= 1 && n <= 5)
//         {
//             Console.WriteLine($"Нет, это не выходной");
//         }
//         else
//         {
//             System.Console.WriteLine("В неделе всего семь дней");
//         }
//     }
// }

// DayOfTheWeek(n);