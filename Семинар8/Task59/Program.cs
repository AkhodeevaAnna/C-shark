// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int minn = Convert.ToInt32(Console.ReadLine());
int maxx = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int [m, n];
int[,] mas = new int [m-1, n-1];

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

int FindMin(int[,]col)
{
    int min = col[0,0];
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i,j] < min) min = col[i,j];
        }
    }
    return min;
}

int FindStringOfNum(int[,]col, int num)
{
int ii = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i,j] == num) ii = i;
        }
    }
    return ii;
}

int FindLineOfNum(int[,]col, int num)
{
int jj = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i,j] == num) jj = j;
        }
    }
    return jj;
}

void FillNewTwoArray (int[,] nums, int ii, int jj, int[,] num)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = jj; j < nums.GetLength(1) - 1; j++)
        {
            nums[i,j] = nums[i,j+1];
        }
    }
    for (int j = 0; j < nums.GetLength(0); j++)
    {
        for (int i = ii; i < nums.GetLength(1) - 1; i++)
        {
            nums[i,j] = nums[i+1,j];
        }
    }
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i,j] = nums[i,j];
        }
    }
}

FillTwoArrayRandom(mass, minn, maxx);
PrintTwoArray(mass);
Console.WriteLine();
int min = FindMin(mass);
int i = FindStringOfNum(mass, min);
int j = FindLineOfNum(mass, min);
Console.Write($"Минимальный элемент {min}, находится на позиции ({i},{j})");
Console.WriteLine();
FillNewTwoArray(mass, i, j, mas);
PrintTwoArray(mas);