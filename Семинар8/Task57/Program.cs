// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int minn = Convert.ToInt32(Console.ReadLine());
int maxx = Convert.ToInt32(Console.ReadLine());

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

int FindMax(int[,]col)
{
    int max = col[0,0];
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i,j] > max) max = col[i,j];
        }
    }
    return max;
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
    // Console.Write($"Min: {min}");
}

void PrintSlovar(int[,]col, int min, int max)
{
    int count = 0;
    for (int n = min; n <= max; n++)
    {
        for (int i = 0; i < col.GetLength(0); i++)
        {
            for (int j = 0; j < col.GetLength(1); j++)
            {
            if (mass[i,j] == n) count++;
            }
        }
        if (count > 0)
        {
            if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4) Console.Write($"{n} встречается {count} раза");
            else Console.Write($"{n} встречается {count} раз");
            Console.WriteLine();
        }
        count = 0;
    }
}

FillTwoArrayRandom(mass, minn, maxx);
PrintTwoArray(mass);
Console.WriteLine();
int min = FindMin(mass);
int max = FindMax(mass);
PrintSlovar(mass, min, max);