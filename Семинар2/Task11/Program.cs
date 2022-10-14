// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int random = new Random().Next(100, 1000);

Console.WriteLine (random);

int num1 = random / 100;
int num3 = random % 10;

int num4 = num1 * 10 + num3;

Console.WriteLine (num4);