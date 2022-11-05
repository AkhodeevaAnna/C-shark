// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string NatNums(int a, int b)
{
if (a <= b) return $"{a}" + NatNums(a + 1, b);
else return string.Empty;
}

string Numbers = NatNums(1, N);
Console.WriteLine(Numbers);