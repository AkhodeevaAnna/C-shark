// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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

void PrintTwoArrayFormat(int[,]col)
{
string str = "";
int symbols = 0;
string space = " ";
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            // Считаем кол-во символов
            str = Convert.ToString(col[i,j]);
            symbols = str.Length;
            // Console.WriteLine($"{str},{symbols}:{space}.");
            // Добавляем необходимое кол-во пробелов
            if (symbols > 1)
            {
            for (int l = 1; l < symbols; l++) space = space + " ";
            }
            Console.Write($"{col[i,j]}{space}");
            space = " ";
        }
    Console.WriteLine();
    }
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);