/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Сколько чисел вы хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());

int[] EnterNumbers(int count)
{
    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}


int FindPositiveNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += 1;
        }
    }
    return sum;
}

int[] array = EnterNumbers(m);
int positiveSum = FindPositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел  = {positiveSum}");