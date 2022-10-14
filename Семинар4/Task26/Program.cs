// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (num > 0)
// {
// num = num / 10;
// count++;
// }
// Console.Write(count);

Console.Write("Введите число: ");
string num = Console.ReadLine();
Console.Write(num.Length);