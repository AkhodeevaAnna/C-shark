﻿// Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите длины предположительных сторон треугольника: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

if (x + y > z && x + z > y && y + z > x)
Console.Write($"Треугольник со сторонами {x}, {y}, {z} существует");
else Console.Write($"Треугольника со сторонами {x}, {y}, {z} НЕ существует");