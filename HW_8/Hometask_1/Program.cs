/*
Задача 54: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
Console.WriteLine("Новый массив");
int[,] array = GetArray(4, 5, 1, 10);
PrintArray(array);
Console.WriteLine("Упорядоченный массив");
SortRowsInArray(array);
PrintArray(array);

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

int[,] SortRowsInArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(1); k++)  // новый индекс для создания дополнительного цикла проверок

                if (array[i, k] > array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;

                }
        }
    }
    return array;
}