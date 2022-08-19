// Заполните спирально массив 4 на 4.


int[,] numbers = new int[4, 4];

CreateSpirale(0, 0, 1);
PrintArray(numbers, 4, 4);
Console.WriteLine();

int[,] array = new int[4, 4];
CreateSpirale2(array);
PrintArray(array, 4, 4);

void CreateSpirale2(int[,] array)// метод с циклами
{
    int count = 1;

    for (int i = 0; i < 4; i++)
    {
        if (array[i, 0] == 0)
        {
            array[i, 0] = count;
            count++;
        }
    }
    for (int i = 0; i < 4; i++)
    {
        if (array[3, i] == 0)
        {
            array[3, i] = count;
            count++;
        }
    }
    for (int i = 2; i > -1; i--)
    {
        if (array[i, 3] == 0)
        {
            array[i, 3] = count;
            count++;
        }
    }
    for (int i = 2; i > 0; i--)
    {
        if (array[0, i] == 0)
        {
            array[0, i] = count;
            count++;
        }
    }
    for (int i = 1; i < 3; i++)
    {
        if (array[i, 1] == 0)
        {
            array[i, 1] = count;
            count++;
        }
    }
    for (int i = 1; i < 3; i++)
    {
        if (array[2, i] == 0)
        {
            array[2, i] = count;
            count++;
        }
    }
    for (int i = 1; i > 0; i--)
    {
        if (array[i, 2] == 0)
        {
            array[i, 2] = count;
            count++;
        }
    }

}

void CreateSpirale(int row, int col, int count)// метод с рекурсией
{
    if (row < 4 && row >= 0 && col < 4 && col >= 0 && numbers[row, col] == 0)
    {
        numbers[row, col] = count;
        count++;
        if (row == 2 && col == 0)
            CreateSpirale(row - 1, col, count);

        CreateSpirale(row, col + 1, count);
        CreateSpirale(row + 1, col, count);
        CreateSpirale(row, col - 1, count);
        CreateSpirale(row - 1, col, count);

    }

}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}