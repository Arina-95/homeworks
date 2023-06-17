Console.Clear();

// // Задача №2
// /* Программа, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.*/

// System.Console.Write("Введите первое число -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int b = Convert.ToInt32(Console.ReadLine());

// int max;
// int min;

// if (a > b)
// {
//     max = a;
//     min = b;
// }
// else
// {
//     max = b;
//     min = a;
// }

// System.Console.WriteLine($"Максимальное число -> {max}");
// System.Console.WriteLine($"Минимальное число -> {min}");


// // Задача № 4
// // Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// System.Console.Write("Введите первое число -> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число -> ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите третье число -> ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// System.Console.WriteLine($"Максимальное число число -> {max}");

// Задача №6
/* Программа, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

// System.Console.Write("Введите число чётность которого вы хотите определить -> ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     System.Console.WriteLine("Заданное число чётное");
// }
// else
// {
//     System.Console.WriteLine("Заданное число нечётное");
// }

// Задача №8
/* Программа, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

// System.Console.Write("Введите число N -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = 1;

// while (current <= n)
// {
//     if (current % 2 == 0)
//     {
//         System.Console.Write(current + " ");
//     }
//     current++;
// }
