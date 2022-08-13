// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// ввод переменных пользователем
Console.WriteLine("Введите значения для первой прямой y = k1 * x + b1 (два числа)");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения для второй прямой y = k2 * x + b2 (два числа)");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

// расчет точки

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    Console.WriteLine($"Координата пересечения ({(b2 - b1) / (k1 - k2)};{k2 * (b2 - b1) / (k1 - k2) + b2})");

}

