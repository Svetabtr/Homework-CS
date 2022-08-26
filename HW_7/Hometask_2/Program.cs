/*
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать 
в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче) 
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();
int[,] array = GetArray(5, 5, 1, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки и столбца через пробел: ");
string readIndex = Console.ReadLine();  // считываем строку целиком
string[] index = readIndex.Split(' '); // создаем массив данных через пробел
int indexI = int.Parse(index[0]);  // присвоили индекс сроки
int indexJ = int.Parse(index[1]);   // присвоили индекс стобца

FindIndexInArray(array, indexI, indexJ);


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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

void FindIndexInArray(int[,] array, int indexI, int indexJ)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == indexI && j == indexJ)
            {
                result = array[i, j];
            }
        }
    }

    if (result != 0)
    {
        Console.WriteLine($"На данной позиции находится элемент со значением {result}");
    }
    else
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    }
}


