// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номера строк, которые надо поменять местами: ");
int string1 = Convert.ToInt32(Console.ReadLine());
int string2 = Convert.ToInt32(Console.ReadLine());

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

void ChangeFirstLastStrings(int[,]col)
{
    int temp = 0;
    int i = col.GetLength(0) - 1;
    for (int j = 0; j < col.GetLength(1); j++)
    {
        temp = col[0,j];
        col[0,j] = col[i, j];
        col[i, j] = temp;
    }
}

void ChangeTwoStrings(int[,]col, int numberOfStringOne, int numberOfStringTwo)
{
    int temp = 0;
    int i1 = numberOfStringOne - 1;
    int i2 = numberOfStringTwo - 1;
    for (int j = 0; j < col.GetLength(1); j++)
    {
        temp = col[i1,j];
        col[i1,j] = col[i2, j];
        col[i2, j] = temp;
    }
}

FillTwoArrayRandom (mass, min, max);
PrintTwoArray(mass);
Console.WriteLine();
// ChangeFirstLastStrings(mass);
// PrintTwoArray(mass);
ChangeTwoStrings(mass, string1, string2);
PrintTwoArray(mass);