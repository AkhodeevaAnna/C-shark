// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// // ПРОСТО
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num % 100 / 10;
// Console.Write(num2);

// // С ПРОВЕРКОЙ
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num / 100 > 1 && num / 100 < 10) Console.Write(num % 100 / 10);
// else Console.WriteLine("Это не трехзначное число");

// // С ЦИКЛОМ
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while ((num / 100 < 1) || (num / 100 >= 10))
{
    Console.WriteLine("Это не трехзначное число, попробуйте еще раз");
    num = Convert.ToInt32(Console.ReadLine());
}
int num2 = num % 100 / 10;
Console.Write(num2);

// int numt1 = num / 100;
// int numt2 = num / 100;
// Console.WriteLine(numt1);
// Console.WriteLine(numt2);