// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] mass = new int [size];

void FillArray (int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        nums[i] = Convert.ToInt32(Console.ReadLine());
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

int Count(int[]col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > 0) count++;
    }
    return count;
}

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
Console.Write($"Кол-во положительных чисел: {Count(mass)}");