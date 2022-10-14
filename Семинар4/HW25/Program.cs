// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > 0)
{
    int Pr = A;
    for (int i = 2; i <= B; i++)
        Pr = Pr * A;
    Console.Write($"{A} в степени {B} = {Pr}");
}
else
    Console.Write($"{A} в степени {B} = 1");