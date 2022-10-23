// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

double[,] mass = new double [m, n];

void FillTwoArrayRandom (double[,] nums, int min, int max)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i,j] = new Random().Next(min,max+1);
        }
    }
}

void PrintTwoArray(double[,]col)
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

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);