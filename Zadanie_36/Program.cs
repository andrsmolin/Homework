// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Generate(int size)  // генерация массива
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

void SummOdd(int[] array) // сумма элементов на нечетных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        };
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях в массиве - {sum} ");
}

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

SummOdd(Generate(x));
