// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
Random random = new Random();

FillArray(numbers, m, n);
PrintArray(numbers, m, n);
ChoiceElement(numbers);

void ChoiceElement(double[,] array)
{
    Console.WriteLine("Задайте номер строки");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте номер столбца");
    int column = Convert.ToInt32(Console.ReadLine());

    if ((row - 1) < 0
        || (row - 1) > array.GetLength(0)
        || (column - 1) < 0
        || (column - 1) > array.GetLength(1))
    {
        Console.WriteLine("Tакого элемента нет");
    }
    else
    {
        Console.Write("Искомый элемент " + array[row - 1, column - 1]);
    }
}
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