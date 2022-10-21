// Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Write("Введите число для перевода в двоичеую систему: ");
int x = Convert.ToInt32(Console.ReadLine());
int ten = x;
string two = "";
if (x == 0) Console.Write($"Число {ten} в двоичной системе: 0");
else
{
while (x > 0)
{
two = $"{x%2}" + two;
x = x / 2;
}
// if (x == 1) two = "1" + two;
Console.Write($"Число {ten} в двоичной системе: {two}");
}