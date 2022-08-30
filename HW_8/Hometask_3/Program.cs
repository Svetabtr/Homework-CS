/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
int[,] arrayA = GetArray(2, 2, 1, 10);
int[,] arrayB = GetArray(2, 2, 1, 10);

Console.WriteLine("Матрица A");
PrintArray(arrayA);

Console.WriteLine("Матрица B");
PrintArray(arrayB);

int[,] arrayC = Multiplication(arrayA, arrayB);

Console.WriteLine("Матрица С - результат умножения матрицы A и матрицы B");
PrintArray(arrayC);


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

int[,] Multiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];

    for (int m = 0; m < arrayA.GetLength(0); m++)
    {
        for (int l = 0; l < arrayA.GetLength(1); l++)
        {
            for (int k = 0; k < 2; k++)  // фиксируем строку/столбец и перемножаем элементы фиксированный строки A на фиксированный столбец B
            {
                arrayC[m, l] += arrayA[m, k] * arrayB[k, l];
            }
        }
    }
    return arrayC;
}