/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int[,] array = GetArray(4, 5, 1, 10);
PrintArray(array);

int[] summa = SumInEveryRow(array);
//для проверки результата
//PrintSumma(summa);   

int index = IndexRowMinSum(summa);
Console.WriteLine($"Номер строки с наименьшей суммой элементов (первая строка 0): {index}");


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
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

int[] SumInEveryRow(int[,] array)
{
    int[] summa = new int[array.GetLength(0)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        summa[k] = sum;
        k++;
    }
    return summa;

}

void PrintSumma(int[] summa)    //для проверки результата
{
    for (int k = 0; k < summa.Length; k++)
    {
        Console.Write($"{summa[k]} ");
    }
}

int IndexRowMinSum(int[] summa)
{
    int minimum = summa[0];
    int rowNumber = 0;
    for (int k = 0; k < summa.Length; k++)
    {
        if (summa[k] < minimum)
        {
            minimum = summa[k];
            rowNumber = k;
        }
    }
    return rowNumber;
}