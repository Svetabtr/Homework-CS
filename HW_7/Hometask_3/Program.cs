﻿/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
int[,] array = GetArray(5, 5, 1, 10);
PrintArray(array);
Console.WriteLine();
AvarageInColumns(array);

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

void AvarageInColumns(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        int i=0;
        for (i = 0; i < array.GetLength(0); i++)
        {
            result = (result + array[i, j]);
        }
        Console.Write($"{result/i}; ");
    }
}
