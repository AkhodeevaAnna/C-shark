// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Ввыедите номер четверти: ");
int ch = Convert.ToInt32(Console.ReadLine());

if (ch == 1)
    Console.Write("Диапозон X (0, +#) диапозон Y (0, +#)");
else if (ch == 2)
    Console.Write("Диапозон X (-#, 0) диапозон Y (0, +#)");
else if (ch == 3)
    Console.Write("Диапозон X (-#, 0) диапозон Y (-#, 0)");
else if (ch == 4)
    Console.Write("Диапозон X (0, +#) диапозон Y (-#, 0)");
else
    Console.Write("Такой четверти нет");