// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray (int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        Console.Write($"Введите элемент {i+1} массива: ");
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

Console.Write("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = new int [A];
FillArray(array);
PrintArray(array);