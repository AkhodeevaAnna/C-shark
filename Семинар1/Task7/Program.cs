// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 56 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int N = num;
while (N > 10)
{
int x = N / 10;
N = N - x * 10;
}
Console.WriteLine($"Последняя цифра числа {num} - {N}");