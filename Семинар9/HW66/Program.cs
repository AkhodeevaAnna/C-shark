// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// while (M > N)
// {
// Console.WriteLine("Число M должно быть меньше N, введите заново: ");
// M = Convert.ToInt32(Console.ReadLine());
// N = Convert.ToInt32(Console.ReadLine());
// }

int NatNums(int a, int b)
{
if (a > b) return 0;
else return a + NatNums(a + 1, b);
}

if (M <= N) Console.WriteLine(NatNums(M, N));
else Console.WriteLine(NatNums(N, M));