// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

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
Console.Write(SearchSumm(m, n));
int SearchSumm(int a, int b)
{
    if (a == b) return a;
    return a += SearchSumm(a + 1, b);
}
