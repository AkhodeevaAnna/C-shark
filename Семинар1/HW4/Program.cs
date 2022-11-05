// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c) Console.WriteLine($"Max = {a}");

else if (b >= a && b >= c) Console.WriteLine($"Max = {b}");

else Console.WriteLine($"Max = {c}");

// int max = a;
// if (b > max)
    // max = b;
// if (c > max)
    // max = c;
// Console.WriteLine($"Max = {max}");
