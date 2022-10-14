// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray (int[] nums)
{
int i = 0;
while (i < nums.Length)
{
nums[i] = new Random().Next(0,2);
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

Console.Write("Введите число элеентов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] mass = new int [x];
FillArray(mass);
PrintArray(mass);