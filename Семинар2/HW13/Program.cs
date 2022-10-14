// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 100 >= 1)
// {
//         while (num / 100 > 9)
//         {
//         num = num / 10;
//         }
//     Console.WriteLine(num % 10);
// }
// else
//     Console.WriteLine("Третьей цифры нет");

Console.WriteLine("Введите число: ");
string L = Console.ReadLine();
int L1 = Convert.ToInt32(L);
if (L1 > 100)
Console.Write(L[2]);
else
Console.WriteLine("Третьей цифры нет");