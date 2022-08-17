// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
Random random = new Random();

FillArray(numbers, m, n);
PrintArray(numbers, m, n);
CalculationAvColumns(numbers);

void CalculationAvColumns(int[,] array)
{
    int r = array.GetLength(0);
    Console.WriteLine("Среднее арифметическое каждого столбца");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        double av = Math.Round(summ / r, 2);
        Console.Write(" " + av);
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

void PrintArray(int[,] array, int rows, int columns)
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