// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray1 = GetArray(m, n);
int[,] randomArray2 = GetArray(m, n);
Console.WriteLine("\nДаны 2 матрицы: ");
PrintArray(randomArray1);
Console.WriteLine();
PrintArray(randomArray2);
int[,] resultArray = GetMultiplyMatrix(randomArray1, randomArray2);
Console.WriteLine("\nПроизведение двух матриц: ");
PrintArray(resultArray);


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 5);
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

int[,] GetMultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArr = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArr[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArr;
}
