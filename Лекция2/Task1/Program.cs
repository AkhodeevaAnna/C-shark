int[] array = {1, 5, 7, 5, 8, 10};
int n = array.Length;
int find = 5;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
