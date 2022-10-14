// Сортировка массива от меньшего к большему

int[] arr = {1, 3, 2, 6, 4, 7, 1, 3, 9, 11, 25, 48, 2, 0};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i=0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array [minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMax(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array [maxPosition])
                maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSortMin(arr);
PrintArray(arr);

SelectionSortMax(arr);
PrintArray(arr);