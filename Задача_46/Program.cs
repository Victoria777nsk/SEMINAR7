// Задача 46: Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
// m = 3, n = 4 -> 1 4 8 19

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0 , 9); 
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue) // Создание двумерного массива.
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i, j]} "); 
        }
    Console.WriteLine();
    }
}
