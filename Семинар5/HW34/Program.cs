// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

while (min < 100 || max < 100 || min > 999 || max > 999)
{
Console.Write("Введен неверный промежуток, в этом случае числа массива будут отрицательными. Введите другой промежуток: ");
min = Convert.ToInt32(Console.ReadLine());
max = Convert.ToInt32(Console.ReadLine());
}

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

void CountEven(int[]col)
{
    int i = 0;
    int pol = 0;
    while (i < col.Length)
    {
        if (col[i] % 2 == 0)
        {
        pol++;
        }
        i++;
    }
    Console.Write($"Кол-во четных чисел в массиве: {pol} ");
}

FillArrayRandom(mass, min, max);
PrintArray(mass);
CountEven(mass);