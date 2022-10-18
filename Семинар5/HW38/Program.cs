// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int minp = Convert.ToInt32(Console.ReadLine());
int maxp = Convert.ToInt32(Console.ReadLine());

double[] mass = new double [size];

void FillArrayRandom (double[] nums, int minp, int maxp)
{
    int i = 0;
    while (i < nums.Length)
    {
        nums[i] = new Random().Next(minp,maxp+1);
        i++;
    }
}

void PrintArray(double[]col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

double FindMax(double[]col)
{
    int i = 0;
    double max = col[i];
    while (i < col.Length)
    {
        if (col[i] > max)
        {
        max = col[i];
        // Console.WriteLine($"i = {i}, элемент: {col[i]}, сумма = {sum}");
        }
        i++;
    }
    return max;
    // Console.Write($"Max: {max}");
}

double FindMin(double[]col)
{
    int i = 0;
    double min = col[i];
    while (i < col.Length)
    {
        if (col[i] < min)
        {
        min = col[i];
        // Console.WriteLine($"i = {i}, элемент: {col[i]}, сумма = {sum}");
        }
        i++;
    }
    return min;
    // Console.Write($"Min: {min}");
}

FillArrayRandom(mass, minp, maxp);
PrintArray(mass);
Console.WriteLine();
double max = FindMax(mass);
Console.WriteLine($"Max: {max}");
double min = FindMin(mass);
Console.WriteLine($"Min: {min}");
double diff = max - min;
Console.Write($"Разность между максимальным и минимальным элементами массива: {diff}");