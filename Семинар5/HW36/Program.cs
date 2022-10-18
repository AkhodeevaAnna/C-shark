// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void SumNumbersOfOddIndex(int[]col)
{
    int i = 0;
    int sum = 0;
    while (i < col.Length)
    {
        if (i % 2 != 0)
        {
        sum = sum + col[i];
        // Console.WriteLine($"i = {i}, элемент: {col[i]}, сумма = {sum}");
        }
        i++;
    }
    Console.Write($"Сумма элементов, стоящих на нечетных позиция в массиве: {sum}");
}

FillArrayRandom(mass, min, max);
PrintArray(mass);
SumNumbersOfOddIndex(mass);