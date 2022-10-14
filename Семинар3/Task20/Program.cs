// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double[] pointOne = new double [2];
// double[] pointTwo = new double [2];

// Console.Write("Ввыедите координаты точки 1: ");
// int length = pointOne.Length;
// int index = 0;
// while (index < length)
// {
//     pointOne[index] = Convert.ToDouble(Console.ReadLine());
//     index++;
// }

// Console.Write("Ввыедите координаты точки 2: ");
// length = pointTwo.Length;
// index = 0;
// while (index < length)
// {
//     pointTwo[index] = Convert.ToDouble(Console.ReadLine());
//     index++;
// }

// Console.Write("Ввыедите X1: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввыедите Y1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввыедите X2: ");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввыедите Y2: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввыедите X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввыедите Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввыедите X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввыедите Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());


// double one = X1 - X2;
// double two = Y1 - Y2;
// double oneone = Math.Pow(one,2);
// double twotwo = Math.Pow(two,2);
// double Z = Math.Sqrt (oneone + twotwo);
// Console.WriteLine(Math.Round(Z,2));

double Z = Math.Sqrt(Math.Pow(X1-X2,2) + Math.Pow(Y1-Y2,2));
Console.WriteLine(Math.Round(Z,2));

// int S = Math.Sqrt
//     (Math.Pow
//         (
//             ((X1 - X2),2) + Math.Pow((Y1 - Y2),2)
//         )
//     );