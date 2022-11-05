// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 1)
{
Console.WriteLine("Введите число больше 0");
N = Convert.ToInt32(Console.ReadLine());
}

string NatNums(int a, int b)
{
if (a >= b) return $"{a} " + NatNums(a - 1, b);
else return string.Empty;
}

string Numbers = NatNums(N, 1);
Console.WriteLine(Numbers);