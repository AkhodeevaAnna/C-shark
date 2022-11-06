// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Введите число для возведения в степень: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень, в которую будет возводиться число: ");
double B = Convert.ToDouble(Console.ReadLine());

double NumInPositivePower(double num, double power)
{
if (power == 1) return num;
else return num * NumInPositivePower(num, power - 1);
}

double NumInNegativePower(double num, double power)
{
// power = Math.Abs(power);
if (power == 1) return num;
else return 1 / (num * NumInNegativePower(num, power - 1));
}

if (B > 0) Console.WriteLine($"{A} в степени {B} = {NumInPositivePower(A, B)}");
else if (B < 0)
{
B = Math.Abs(B);
Console.WriteLine($"{A} в степени {B} = {1 / NumInPositivePower(A, B)}");
}
else if (B == 0) Console.WriteLine($"{A} в степени {B} = 1");