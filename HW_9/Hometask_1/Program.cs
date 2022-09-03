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

if (numberM<numberN)
{
Console.WriteLine(Number(numberM, numberN));
}
else
{
    Console.WriteLine(Number2(numberM, numberN));
}


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


string Number2(int m, int n)
{
    if (m >= n)
    {
        return $"{m} " + Number2(m-1,n);
    }
    else
    {
        return string.Empty;
    }
}