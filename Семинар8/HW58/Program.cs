// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите кол-во строк в массиве 1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк в массиве 2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int [m1, n1];
int[,] matrix2 = new int [m2, n2];

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

FillTwoArrayRandom(matrix1, min, max);
FillTwoArrayRandom(matrix2, min, max);
Console.WriteLine("Матрица 1:");
PrintTwoArray(matrix1);
Console.WriteLine("Матрица 2:");
PrintTwoArray(matrix2);
if (matrix1.GetLength(1) == matrix2.GetLength(0))
Console.WriteLine("Матрицы 1 и 2 могут быть перемножены");
else
Console.WriteLine($"Матрицы 1 и 2 НЕ могут быть перемножены,так как кол-во стобцов ({matrix1.GetLength(1)}) матрицы 1 НЕ равно кол-ву строк ({matrix2.GetLength(0)}) матрицы 2");