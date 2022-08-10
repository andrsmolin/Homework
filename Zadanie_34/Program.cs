//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2

int[] Generate(int size)  // генерация массива
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

void CountHonest(int[] array) // количество четных
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        };
    }
    Console.WriteLine($"Количество четных элементов в массиве - {count} ");
}

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

CountHonest(Generate(x));