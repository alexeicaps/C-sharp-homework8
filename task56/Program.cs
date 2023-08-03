// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = GetArray(4, 4);
PrintArray(array);


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void GetRowsNumber(int[,] array)
{
    int row = 0;
    int sum = 0;
    int minSum = 0;
    Console.Write("Сумма каждой строки: ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            {
                if (i == 0)
                minSum = sum;
            }
        }
        
        Console.Write($"{sum} ");
        if (sum < minSum)
        {
            minSum = sum;
            row = i + 1;

        }
    }
    Console.WriteLine();
    Console.WriteLine($"\nСумма = {minSum}, строка с наименьшей суммой элементов: {row}");
}

GetRowsNumber(array);
