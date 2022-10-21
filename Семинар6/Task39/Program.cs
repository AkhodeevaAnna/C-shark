// Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void FlipArray(int[]col)
{
    int i = 0;
    int x = 0;
    while (i < col.Length/2)
    {
        x = mass[i];
        mass[i] = mass[mass.Length - 1 - i];
        mass[mass.Length - 1 - i] = x;
        i++;
        // Console.WriteLine($"i = {i}, элемент: {col[i]}, сумма = {sum}");
    }
    // Console.Write($"Сумма элементов, стоящих на нечетных позиция в массиве: {sum}");
}

FillArrayRandom(mass, min, max);
PrintArray(mass);
FlipArray(mass);
Console.WriteLine();
Console.Write($"Перевернутый массив: ");
PrintArray(mass);