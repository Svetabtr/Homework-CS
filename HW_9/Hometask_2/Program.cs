/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{

    if (number1 % 2 == 0)
    {
        Console.WriteLine($"Сумма четных чисел = {GetSum(number1, number2)}");
    }

    else
    {
        Console.WriteLine($"Сумма четных чисел = {GetSum(number1 + 1, number2)}");
    }
}

else
{
    Console.WriteLine("Невозможно вычислить сумму элементов на данном промежутке");
}

int GetSum(int number1, int number2)
{
    int result = 0;
    if (number1 > number2)
    {
        return result;
    }
    else
    {
        return result = number1 + GetSum(number1 + 2, number2);
    }
}
