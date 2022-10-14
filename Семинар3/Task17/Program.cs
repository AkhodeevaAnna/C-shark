// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Ввыедите X точки: ");
// double X = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ввыедите Y точки: ");
// double Y = Convert.ToDouble(Console.ReadLine());

double[] point = new double [2];
int length = point.Length;
int index = 0;
Console.Write("Ввыедите координаты точки: ");

while (index < length)
{
    point[index] = Convert.ToDouble(Console.ReadLine());
    index++;
}

// Console.Write("Ввыедите X точки: ");
// point[0] = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ввыедите Y точки: ");
// point[1] = Convert.ToDouble(Console.ReadLine());

if (point[0] > 0 && point[1] > 0)
    Console.Write("Точка находится в первой четверти");
else if (point[0] < 0 && point[1] > 0)
    Console.Write("Точка находится во второй четверти");
else if (point[0] < 0 && point[1] < 0)
    Console.Write("Точка находится в третьей четверти");
else if (point[0] > 0 && point[1] < 0)
    Console.Write("Точка находится в четвертой четверти");
else if (point[0] == 0 || point[1] == 0)
    Console.Write("Точка находится на системе координат");