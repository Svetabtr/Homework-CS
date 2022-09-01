/*
Задача 64: 
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/ 

Console.Clear();
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

string Number(int m, int n)
{
    if (n >= m)
    {
        return $"{n} " + Number(m, n-1);
    }
    else
    {
        return string.Empty;
    }
}
Console.WriteLine(Number(numberM, numberN));
