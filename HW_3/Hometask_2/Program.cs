/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

Console.WriteLine("Введите координаты точки A: ");
double AX = Convert.ToDouble(Console.ReadLine());
double AY = Convert.ToDouble(Console.ReadLine());
double AZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
double BX = Convert.ToDouble(Console.ReadLine());
double BY = Convert.ToDouble(Console.ReadLine());
double BZ = Convert.ToDouble(Console.ReadLine());

double AB = Math.Round(Math.Sqrt(Math.Pow((AY-BY),2) + Math.Pow((AX-BX),2) +Math.Pow((AZ-BZ),2)),2);
Console.WriteLine(AB);