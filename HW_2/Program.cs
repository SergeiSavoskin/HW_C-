/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int m = (n / 100);
int m1 = m*100;
int m2 = (n - m1);
int m3 = (m2 / 10);
Console.WriteLine(m3);