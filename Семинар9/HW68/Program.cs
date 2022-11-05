// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

while (m < 0 || n < 0)
{
Console.WriteLine("Число m и n должны быть неотрицательными, введите заново: ");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
}

int NatNums(int m, int n)
{
if (m == 0) return n + 1;
else if (m > 0 && n == 0) return NatNums(m - 1, 1);
else return NatNums(m - 1, NatNums(m, n - 1));
}

int Numbers = NatNums(m, n);
Console.WriteLine(Numbers);