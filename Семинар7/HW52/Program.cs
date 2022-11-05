// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string AvergeOfEveryColumn(int[,]col)
{
double avg = 0;
string averge = "";
double sum = 0;
    for (int j = 0; j < col.GetLength(1); j++)
    {
        for (int i = 0; i < col.GetLength(0); i++)
        {
            sum += col[i,j];
        }
        avg = sum / col.GetLength(0);
        sum = 0;
        averge += $"{avg}  ";
    }
    return averge;
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);
Console.WriteLine($"Среднее арифметическое каждого столбца: {AvergeOfEveryColumn(mass)}");

// Буткэмп
// Console.Clear();
// Console.Write("Введите кол-во строк массив: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mass = new int [m, n];


// void FillTwoArrayTable (int[,] nums)
// {
//     for (int i = 0; i < nums.GetLength(0); i++)
//     {
//         for (int j = 0; j < nums.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 nums[i,j] = j + 1;
//             }
//             else if (j == 0)
//             {
//                 nums[i,j] = i + 1;
//             }
//             else if (i > 0 && j > 0)
//             {
//                 nums[i,j] = nums[0,j] * nums[i,0];
//             }
//         }
//     }
// }
// FillTwoArrayTable(mass);
// PrintTwoArray(mass);