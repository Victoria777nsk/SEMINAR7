int[] GetArray(int size = 12, int minValue = -100, int maxValue = 100) // Значения по умолчанию.
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


static void Swap(ref int x, ref int y) // Метод для обмена элементов массива.
{
    var t = x;
    x = y;
    y = t;
}


int Partition(int[] array, int minIndex, int maxIndex) // Метод, возвращающий индекс опорного элемента.
{
    var pivot = minIndex - 1;
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);
    return pivot;
}


int[] QuickSort(int[] array, int minIndex, int maxIndex) // Быстрая сортировка.
{
    if (minIndex >= maxIndex) return array;
    
    var pivotIndex = Partition(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

int[] QuickSortStart(int[] array)
{
    return QuickSort(array, 0, array.Length - 1);
}

var array = GetArray();
Console.WriteLine("Массив: {0}", string.Join(", ", array));
Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSortStart(array)));