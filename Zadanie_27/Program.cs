void Summ(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + (number % 10);
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в числе - {summ}");
}
Console.WriteLine("Введите положительное число");
int num = Convert.ToInt32(Console.ReadLine());

Summ(num);

/*int Count(int number) // проверка на количество цифр в числе
{
    int b = 10;
    int i = 0;
    while (number > 0)
    {
        number = number / b;
        i++;
    }
    return i;
}

void Summ(int num, int i)
{
    int power = 1;
    int summ = 0;
    for (int j = 0; j < i; j++)
    {
        summ = summ + (num / power % 10);
        power *= 10;

    }

    Console.WriteLine($"Сумма цифр в числе {num} = {summ}");
}
Console.WriteLine("Введите положительное число");
int num = Convert.ToInt32(Console.ReadLine());

Summ(num, Count(num));*/