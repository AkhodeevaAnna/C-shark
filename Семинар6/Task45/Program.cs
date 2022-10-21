// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] mass = new int [size];

void FillArrayRandom (int[] nums, int min, int max)
{
    int i = 0;
    while (i < nums.Length)
    {
        nums[i] = new Random().Next(min,max+1);
        i++;
    }
}

void PrintArray(int[]col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] miss = new int [mass.Length];

void CloneArray (int[]col, int[]cool)
{
    int i = 0;
    while (i < col.Length)
    {
        cool[i] = col[i];
        i++;
        // Console.WriteLine($"i = {i}, элемент: {col[i]}, сумма = {sum}");
    }
    // Console.Write($"Сумма элементов, стоящих на нечетных позиция в массиве: {sum}");
}

FillArrayRandom(mass, min, max);
PrintArray(mass);
CloneArray(mass, miss);
Console.WriteLine();
Console.Write($"Первый массив: ");
PrintArray(mass);
CloneArray(mass, miss);
Console.WriteLine();
Console.Write($"Второй массив: ");
PrintArray(miss);