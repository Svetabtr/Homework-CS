/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int FindSecondDigitNumber(int num)
{
    int SecondDigit = num/10%10;
    return SecondDigit;
}

int result = FindSecondDigitNumber(Number);
Console.WriteLine($"Вторая цифра этого числа - {result}");