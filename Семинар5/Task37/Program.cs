// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

// Console.WriteLine();
// int [] result = mass;
// // четное число
// if (size % 2 == 0)
// {
//     int[] mass2 = new int [size/2];
//     int i = 0;
//     while (i < mass.Length / 2)
//     {
//         mass2[i] = mass[i]*mass[mass.Length-1-i];
//         Console.WriteLine($"{mass[i]} * {mass[mass.Length-1-i]} = {mass2[i]}");
//         i++;
//     }
// result = mass2;
// }

// // нечетное число
// else
// {
//     int[] mass3 = new int [size/2 + 1];
//     int i = 0;
//     while (i < mass.Length / 2)
//     {
//         mass3[i] = mass[i]*mass[mass.Length-1-i];
//         Console.WriteLine($"{mass[i]} * {mass[mass.Length-1-i]} = {mass3[i]}");
//         i++;
//     }
// mass3[size/2] = mass[mass.Length / 2];
// result = mass3;
// }
// PrintArray(result);




Console.WriteLine();
// int [] result = mass;
// // четное число
// if (size % 2 == 0)
// {
    int[] mass2 = new int [size/2];
    int i = 0;
    while (i < mass.Length / 2)
    {
        mass2[i] = mass[i]*mass[mass.Length-1-i];
        Console.WriteLine($"{mass[i]} * {mass[mass.Length-1-i]} = {mass2[i]}");
        i++;
    }
if (size % 2 > 0) mass2[size/2] = mass[mass.Length / 2];

PrintArray(mass2);

// result = mass2;
// }

// нечетное число
// else
// {
//     int[] mass3 = new int [size/2 + 1];
//     int i = 0;
//     while (i < mass.Length / 2)
//     {
//         mass3[i] = mass[i]*mass[mass.Length-1-i];
//         Console.WriteLine($"{mass[i]} * {mass[mass.Length-1-i]} = {mass3[i]}");
//         i++;
//     }
// mass3[size/2] = mass[mass.Length / 2];
// result = mass3;
// }
// PrintArray(result);