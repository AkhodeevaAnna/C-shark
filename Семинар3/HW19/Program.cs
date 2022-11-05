// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int one = num / 10000;
int two = num / 1000 % 10;
int four = num / 10 % 10;
int five = num % 10;
if (num / 10000 < 10 && num / 10000 > 0)
{
    if (one == five && two == four) Console.Write("Данное число палиндром");
    else Console.Write("Данное число НЕ палиндром");
}
else Console.Write("Это НЕ пятизначное число");