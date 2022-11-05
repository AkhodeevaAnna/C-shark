// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int MinN = N - N * 2;
int a = MinN;
while (MinN <= a && a < N)
{
    Console.Write($"{a} ");
    a = a + 1;
}
Console.Write($"{N} ");