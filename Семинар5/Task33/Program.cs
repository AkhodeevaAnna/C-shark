// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

FillArrayRandom(mass, min, max);
PrintArray(mass);

Console.Write("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
string answer = " ";
while (i < mass.Length)
{
    if (mass[i] == num)
    {
        answer = "Да";
        break;
    }
    else if (mass[i] != num)
    {
        answer = "Нет";
    }
i++;
}
Console.Write(answer);
// Console.Write($"Массив после работы программы: ");
// PrintArray(mass);