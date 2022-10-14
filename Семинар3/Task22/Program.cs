// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int S = 1;
if (N > 0)
{
    while (S <= N)
    {
        Console.Write($"{Math.Pow(S,2)} ");
        S++;
    }
}
else
    Console.Write("Таких чисел нет ");