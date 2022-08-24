void Rec(int number1, int number2)
{
    if (number2 < number1) return;

    Console.WriteLine(number1);
    number1++;
    Rec(number1, number2);
}
Rec(4, 8);

void Recur(int number1, int summ = 0)
{
    if (number1 == 0)
    {
        Console.Write(summ);
        return;
    }
    else
    {
        summ += number1 % 10;
        number1 = number1 / 10;
    }
    Recur(number1, summ);
}

Recur(88);