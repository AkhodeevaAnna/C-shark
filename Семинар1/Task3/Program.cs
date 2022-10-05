// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите номер дня недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 1)
{
Console.WriteLine("Понедельник");
}

if (numberDay == 2)
{
Console.WriteLine("Вторник");
}

if (numberDay == 3)
{
Console.WriteLine("Среда");
}

if (numberDay == 4)
{
Console.WriteLine("Четверг");
}

if (numberDay == 5)
{
Console.WriteLine("Пятница");
}

if (numberDay == 6)
{
Console.WriteLine("Суббота");
}

if (numberDay == 7)
{
Console.WriteLine("Воскресенье");
}

if (numberDay > 7)
{
Console.WriteLine("Дня недели с таким номером нет");
}