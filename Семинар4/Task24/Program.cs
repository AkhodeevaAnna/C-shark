// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for  (int i = 1; i <= A; i++) sum = sum + i;
Console.Write(sum);

void FillArray (int[] nums)
{
int i = 0;
while (i < nums.Length)
{
nums[i] = i + 1;
i++;
}
}

void PrintArray(int[]col)
{
int position = 0;
while (position < col.Length)
{
Console.Write($"{col[position]} ");
position++;
}
}

int Sum (int[]mass, int num)
{
int i = 0;
int sum = 0;
while (i < num)
{
    sum = sum + mass[i];
    i++;
}
return sum;
}

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [A];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(Sum(array, A));