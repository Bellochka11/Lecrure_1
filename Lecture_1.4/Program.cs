// Сортировка массива от меньшего к большему

int[] arr = { 1, 5, 4, 3, 2, 6, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; //ищем максимальный элемент
        }
        int temporary = array[i]; //временный элемент
        array[i] = array[minPosition]; // свап
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);