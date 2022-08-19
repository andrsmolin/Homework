// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
Random random = new Random();

FillArray(numbers, m, n);
PrintArray(numbers);
Console.WriteLine();

SortedRows(numbers);
PrintArray(numbers);

void SortedRows(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int temp;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[n, j] > array[n, i])
                {
                    temp = array[n, i];
                    array[n, i] = array[n, j];
                    array[n, j] = temp;
                }
            }
        }
    }
}
void FillArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
