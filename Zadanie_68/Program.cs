// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

decimal m, n;
while (true)
{
    Console.WriteLine("Введите первое число");
    m = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    n = Convert.ToDecimal(Console.ReadLine());
    if (m >= 0 && n >= 0) break;
    Console.WriteLine("Введите неотрицательное число");
}

Console.Write(Accerman(m, n));

decimal Accerman(decimal a, decimal b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return Accerman(a - 1, 1);
    if (a > 0 && b > 0) return Accerman(a - 1, Accerman(a, b - 1));

    return 0;
}
