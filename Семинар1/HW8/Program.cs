// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (N > 1)
{
    while (a <= N)
    {
        if (a % 2 == 0)
        {
            Console.Write($"{a} ");
        }
        a = a + 1;
    }
}
else
{
    Console.WriteLine("Таких чисел нет");
}