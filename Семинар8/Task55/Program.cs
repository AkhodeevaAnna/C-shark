// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int [m, n];

void FillTwoArrayRandom (int[,] nums, int min, int max)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i,j] = new Random().Next(min,max+1);
        }
    }
}

void PrintTwoArray(int[,]col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i,j]} ");
        }
    Console.WriteLine();
    }
}

void ChangeLineStrings(int[,]col)
{
    int temp = 0;
    int j = 1;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        while (j < col.GetLength(1))
        {
            temp = col[i,j];
            col[i,j] = col[j, i];
            col[j, i] = temp;
            j++;
        }
    j = i + 1;
    }
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);
Console.WriteLine();
if (m != n) Console.Write("Невозможно поменять строки со стролбацами, так как их разное кол-во");
else
{
Console.WriteLine();
ChangeLineStrings(mass);
PrintTwoArray(mass);
}