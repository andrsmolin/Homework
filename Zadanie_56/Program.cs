// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
Random random = new Random();

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

int[] summ = new int[numbers.GetLength(0)];

Summ(numbers);
SeachMinSumm(summ);

void SeachMinSumm(int[] array)
{
    int minSumm = array[0];
    int minPosition = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumm)
        {
            minSumm = array[i];
            minPosition = i;
        }
    }
    Console.WriteLine($"Минимальная сумма в {minPosition + 1} строке равна {minSumm} ");
}

void Summ(int[,] array)
{
    Console.WriteLine("Массив построчных сумм: ");
    for (int n = 0; n < array.GetLength(0); n++)
    {
        int summRow = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            summRow += array[n, i];
        }
        summ[n] = summRow;
        Console.Write(summ[n] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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
