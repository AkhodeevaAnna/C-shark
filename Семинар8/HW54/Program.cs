// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortTwoDown(int[,]col)
{
    for (int j = 0; j < col.GetLength(0); j++)
    {
        int maxIndex = 0;
        int i = 0;
        int pos = 0;
        int temp = 0;
        while (pos < col.GetLength(1))
        {
        i = pos;
        maxIndex = pos;
            while (i < col.GetLength(1))
            {
                if (col[j,i] > col[j,maxIndex]) maxIndex = i;
                i++;
            }
            temp = col[j,pos];
            col[j,pos] = col[j,maxIndex];
            col[j,maxIndex] = temp;
            pos++;
        }
    }
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);
SortTwoDown(mass);
Console.WriteLine();
PrintTwoArray(mass);

// ОДНОМЕРНЫЙ МАССИВ

// Console.Clear();
// Console.Write("Введите кол-во элеметов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите промежуток для генератора случайных чисел: ");
// int min = Convert.ToInt32(Console.ReadLine());
// int max = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int [m];

// void FillArrayRandom (int[] nums, int min, int max)
// {
//     for (int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(min,max+1);
//     }
// }

// void PrintArray(int[]col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
// }

// void SortOneDown(int[]col)
// {
//     int maxIndex = 0;
//     int i = 0;
//     int pos = 0;
//     int temp = 0;
//     while (pos < col.Length)
//     {
//     i = pos;
//     maxIndex = pos;
//         while (i < col.Length)
//         {
//             if (col[i] > col[maxIndex]) maxIndex = i;
//             i++;
//         }
//         temp = col[pos];
//         col[pos] = col[maxIndex];
//         col[maxIndex] = temp;
//         pos++;
//     }
// }

// FillArrayRandom(mass, min, max);
// PrintArray(mass);
// Console.WriteLine();
// SortOneDown(mass);
// Console.WriteLine();
// PrintArray(mass);