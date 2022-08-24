// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

PrintMultipleThree(m, n);

void PrintMultipleThree(int a, int b)
{
    if (b >= a)
    {
        if (a % 3 == 0)
        {
            Console.Write(a + " ");
        }

        PrintMultipleThree(a + 1, b);
    }
}