// У нас есть график, где даны отрезок 1 - (х1; x2) и отрезок 2 (х3, x4)
// ​Необходимо составить код, который находит их пересечение.
// Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка или ничего
// С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков,
// общую точку или «не пересекаются».

Console.Write("Введите границы отрезка 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите границы отрезка 2: ");
int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());

// Находим max
int max = x1;
if (x2 > max) max = x2;
if (x3 > max) max = x3;
if (x4 > max) max = x4;
Console.WriteLine($"max = {max}");

// Находим min
int min = x1;
if (x2 < min) min = x2;
if (x3 < min) min = x3;
if (x4 < min) min = x4;
Console.WriteLine($"min = {min}");

// Находим общую длину
int l = max - min;
Console.WriteLine($"Общая длина = {l}");

// Вычисление длин отрезков
int L1 = Math.Abs(x1-x2);
int L2 = Math.Abs(x3-x4);
Console.WriteLine($"Длина первого отрезка = {L1}");
Console.WriteLine($"Длина второго отрезка = {L2}");
int L = L1 + L2;
Console.WriteLine($"Сумма длин отрезков = {L}");

// Сравнение длин отрезков
// Общая точка
if (L == l)
{
    if (x1 == x3 || x1 == x4)
    Console.WriteLine($"Отрезки имеют общую точку {x1}");
    else
    Console.WriteLine($"Отрезки имеют общую точку {x2}");
}
// Общий отрезок
else if (L > l)
{
// Находим y1
int y1 = 0;
    if ((x1 != max) && (x1 != min))
        y1 = x1;
    else if ((x2 != max) && (x2 != min))
        y1 = x2;
    else if ((x3 != max) && (x3 != min))
        y1 = x3;
    else if ((x4 != max) && (x4 != min))
        y1 = x4;
// Находим y2
int y2 = 0;
    if ((x1 != max) && (x1 != min) && (x1 != y1))
        y2 = x1;
    else if ((x2 != max) && (x2 != min) && (x2 != y1))
        y2 = x2;
    else if ((x3 != max) && (x3 != min) && (x3 != y1))
        y2 = x3;
    else if ((x4 != max) && (x4 != min) && (x4 != y1))
        y2 = x4;
// Правильное расположение точек отрезка пересечения
if (y1 > y2)
    Console.WriteLine($"Отрезки имеют общий отрезок с точками {y2} {y1}");
else
    Console.WriteLine($"Отрезки имеют общий отрезок с точками {y1} {y2}");
}
else
    Console.WriteLine($"Отрезки не пересекаются");