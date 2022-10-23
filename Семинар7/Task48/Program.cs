// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();
Console.Write("Введите кол-во строк массив: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int [m, n];

void FillTwoArrayFormula (int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i,j] = i + j;
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

FillTwoArrayFormula(mass);
PrintTwoArray(mass);