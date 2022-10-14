void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10,99);
        index++;
    }
}
int random = new Random().Next(10,100);

Console.WriteLine (random);

int a = random / 10;
int b = random % 10;

if (a > b)
    Console.Write(a);
else if (b > a)
    Console.Write(b);
if (a == b)
    Console.Write(a + " цифры равны");