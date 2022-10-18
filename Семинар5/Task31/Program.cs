// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// Ввести размер массива и задать массив
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток для генератора случайных чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] mass = new int [size];

// Метод для заполнения массива случайными числами (-9;10)

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

// Заполнение массива случайными числами (-9;10)
FillArrayRandom(mass, min, max);
PrintArray(mass);
// Если array[i] < 0 otr = otr + array[i]
// Если array[i] > 0 pol = pol + array[i]
int i = 0;
int otr = 0;
int pol = 0;
while (i < mass.Length)
{
    if (mass[i] < 0)
    {
        otr = otr + mass[i];
    }
    if (mass[i] > 0)
    {
        pol = pol + mass[i];
    }
i++;
}
// Вывести сумму положительных и сумму отрицательных
Console.WriteLine($"Сумма отрицательных чисел = {otr}, сумма положительных чисел = {pol}");