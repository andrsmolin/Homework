void Raise()
{
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
    int a = Convert.ToInt32(Console.ReadLine());
    int x1 = 1;

    for (int i = 0; i < a; i++)
    {
        x1 = x1 * x;
    }
    Console.Write($"Число {x} в степени {a} равно {x1}");
}

Raise();