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

void PrintArray(int[] array) // печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Sort(int[] array) // сортировка массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[min]))
            {
                min = j;
            }
        }

        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
    return array;
}


Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

PrintArray(Sort(Generate(x)));
