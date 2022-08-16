/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());

int DigitsSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit = num % 10;
        result = result + digit;
        num = num / 10;
    }
    return result;
}

int Summa = DigitsSum(number);
Console.WriteLine($"Сумма чисел данного числа = {Summa}");