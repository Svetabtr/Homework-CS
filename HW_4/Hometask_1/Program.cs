/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/ 

Console.WriteLine("Введите два числа A и B: ");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine()); 

double NumberAPowToB (int num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}

double NewNum = NumberAPowToB(numA, numB);
Console.WriteLine($"Число A в степени B = {NewNum}");