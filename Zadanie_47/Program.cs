// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];
Random random = new Random();

FillArray(numbers, m, n);
PrintArray(numbers, m, n);

void FillArray(double[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 1);
        }
    }
}

void PrintArray(double[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}