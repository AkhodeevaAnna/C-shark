// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string FindNum(int[,]col, int num)
{
string coordinats = "";
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i,j] == num) coordinats += $"({i},{j}) ";
        }
    }
    if (coordinats == "") coordinats = "-";
    return coordinats;
}

void FindNumOfPosition(int[,]col, int m, int n)
{
if (m >= col.GetLength(0) || n >= col.GetLength(1) || m < 0 || n < 0) 
Console.Write($"Такой позиции в массиве НЕТ, размер массива {col.GetLength(0)}*{col.GetLength(1)}");
else
Console.Write($"Элемент, стоящий на позиции {m}*{n} = {col[m,n]}");
}

FillTwoArrayRandom(mass, min, max);
PrintTwoArray(mass);
Console.Write("Введите число для проверки его наличия в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {x} находится в массиве на позиции(-ях): {FindNum(mass, x)}");
Console.Write("Введите позицию для проверки наличия такого элемента: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
FindNumOfPosition(mass, x1, x2);