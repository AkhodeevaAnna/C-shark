// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int SumOfNums(int num)
{
int sum = 0;
while (num > 9)
{
    sum += num % 10;
    num = num / 10;
}
return sum + num;
}

int SumOfNumsRec(int num)
{
if (num < 10) return num;
else return num%10 + SumOfNums(num/10);
}

Console.WriteLine(SumOfNums(num));
Console.WriteLine(SumOfNumsRec(num));