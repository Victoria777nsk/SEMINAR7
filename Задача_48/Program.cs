// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m + n.
// Выведите полученный массив на экран (таблица умножения, таблица Пифагора).

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MultiplicationTable()
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
MultiplicationTable();