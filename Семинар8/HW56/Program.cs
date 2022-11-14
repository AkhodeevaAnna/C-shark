// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintArray(int[]mol)
{
    for (int i = 0; i < mol.Length; i++)
    {
            Console.Write($"{mol[i]} ");
    }
}

int[] sum = new int [m];

void ArrayOfSumStrings(int[,]col, int[]summ)
{
int sum = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            sum += col[i,j]; 
        }
        summ[i] = sum;
        sum = 0;
    }
}

int FindIndexOfMin (int[]col)
{
int min = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] < col[min])
        {
            min = i;
        }
    }
    return min;
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);
ArrayOfSumStrings(mass,sum);
Console.WriteLine();
PrintArray(sum);
Console.WriteLine();
int indexMin = FindIndexOfMin(sum);
Console.Write($"Наименьшая сумма элементов в СТРОКЕ: {indexMin + 1}");;
