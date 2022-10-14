// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    int i = 1;
    int pr = 1;
    while (i <= N)
    {
        pr = pr * i;
        i++;
    }
Console.Write(pr); 
}
else 
Console.Write("0");