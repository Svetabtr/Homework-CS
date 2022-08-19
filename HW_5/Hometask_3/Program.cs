/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double[] array = GetArray(10);
Console.WriteLine();

double FindMaxValue(double[] arr)
{
    double maxValue = new double();
    maxValue = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    return maxValue;

}

double FindMinValue(double[] arr)
{
    double minValue = new double();
    minValue = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
    }

    return minValue;

}

double max = FindMaxValue(array);
double min = FindMinValue(array);

Console.WriteLine($"Разница между максимальным значением {max} и минимальным значением {min} = {max-min}");
