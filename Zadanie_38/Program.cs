// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

SubtractionMaxMin(Generate(x));

double[] Generate(int size)  // генерация массива
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-999, 1000);
        array[i] = array[i] / 100;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

void SubtractionMaxMin(double[] array) // разница максимума и минимума
{
    double max = array[0];
    double min = array[0];
    double subt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        };
        if (array[i] < min)
        {
            min = array[i];
        };
        subt = max - min;
    }
    Console.WriteLine($"Разница между максимумом {max} и минимумом {min} равна {subt}");
}