// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string NatNums(int a, int b)
{
if (a <= b) return $"{a} " + NatNums(a + 1, b);
else return string.Empty;
}

string NatNumsDown(int a, int b)
{
if (a >= b) return $"{a} " + NatNumsDown(a - 1, b);
else return string.Empty;
}

while (M < 1 || N < 1)
{
Console.WriteLine("В этом промежутке находятся не только натуральные числа, введите два натуральных числа (больше 0): ");
M = Convert.ToInt32(Console.ReadLine());
N = Convert.ToInt32(Console.ReadLine());
}
if (M <= N)
{
Console.WriteLine(NatNums(M, N));
}
else Console.WriteLine(NatNumsDown(M, N));