// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите предпологаемый квадрат числа: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (result == num * num)
{
Console.WriteLine($"{result} - квдарат {num}");
}
else
{
Console.WriteLine($"{result} НЕ квдарат {num}");
}