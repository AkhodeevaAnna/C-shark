// Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Сколько чисел из ряда Фибоначчи надо вывести? ");
int N = Convert.ToInt32(Console.ReadLine());

double[] mass = new double [N];

void Fib (double[] nums, int N)
{
    nums[0] = 0;
    nums[1] = 1;
    int i = 2;
    while (i < N)
    {
        nums[i] = nums [i - 1] + nums [i - 2];
        i++;
    }
}

void PrintArray(double[]col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}


Fib(mass, N);
Console.Write($"{N} чисел из ряда Фибоначчи: ");
PrintArray(mass);