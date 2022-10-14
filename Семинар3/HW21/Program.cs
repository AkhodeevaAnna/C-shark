// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] one = new double[3];
double[] two = new double[3];

Console.Write("Введите координаты первой точки: ");
int i = 0;
while (i < one.Length)
{
    one[i] = Convert.ToDouble(Console.ReadLine());
    i++;
}

Console.Write("Введите координаты второй точки: ");
i = 0;
while (i < two.Length)
{
    two[i] = Convert.ToDouble(Console.ReadLine());
    i++;
}

double S = Math.Sqrt ((Math.Pow((one[0] - two[0]),2))+(Math.Pow((one[1] - two[1]),2))+(Math.Pow((one[2] - two[2]),2)));
Console.WriteLine(Math.Round(S, 2));