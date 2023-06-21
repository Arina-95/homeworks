// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// // является ли оно палиндромом.

// // через метод bool
// // bool FindPalindrom1 (int a)
// // {
// //     if (a % 100000 == 0)
// //     {
// //         if (a / 10000 == a % 10 && (a / 1000) %10 == (a/10) % 10) return ;
// //     else return false;
// //     }
// //     else return false;
// // }

// // через метод void
// void FindPalindrom2(int a)
// {
//     if (a / 100000 == 0)
//     {
//         if (a / 10000 == a % 10 && (a / 1000) % 10 == (a / 10) % 10)
//         {
//             System.Console.WriteLine($"{a} это палиндром");
//         }
//         if (a / 10000 != a % 10 || (a / 1000) % 10 != (a / 10) % 10)
//         {
//             System.Console.WriteLine(($"{a} это не палиндром"));
//         }
//     }
//     else
//     {
//         System.Console.WriteLine($"{a} это не пятизначное число");
//     }
// }

//     System.Console.WriteLine("Введите пятизначное число -> ");
//     int a = Convert.ToInt32(Console.ReadLine());

//     // System.Console.WriteLine(FindPalindrom2(a));
//     FindPalindrom2(a);



// // Задача 21
// // Напишите программу, которая принимает на вход координаты 
// // двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2)),2);
// }

//     System.Console.WriteLine("задайте координаты xa -> ");
//     double xa = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("задайте координаты xb -> ");
//     double xb = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("задайте координаты ya -> ");
//     double ya = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("задайте координаты yb -> ");
//     double yb = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("задайте координаты za -> ");
//     double za = Convert.ToDouble(Console.ReadLine());
//     System.Console.WriteLine("задайте координаты zb -> ");
//     double zb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"Растояние между точками в 3х мерной плоскости с заданными координатами равно -> {FindDistance(xa, ya, za, xb, yb, zb)}");



// // Задача 23
// // Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу кубов чисел от 1 до N.

// void TabOfCubes(int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         System.Console.WriteLine(Math.Pow(i, 3));
//     }
// }

// System.Console.WriteLine("Введите число -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// TabOfCubes(n);