﻿/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int m = (n / 100);
int m1 = m*100;
int m2 = (n - m1);
int m3 = (m2 / 10);
Console.WriteLine(m3);
*/


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

Console.Clear();
Console.Write("Введите ваше число число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
int i = 1;
int c = n;

while (n / 10 >= 1)  
{
    i = i * 10;
    count++;
    n = n / 10;
}


if (count < 3)
{
    Console.WriteLine("Разрядность числа меньше 3-х");
}

// count - Разрядность числа
// x - количество разрядов на которые стоит урезать число
// count - x = 3; x = count - 3;

int x = (count - 3);
int m2 = Convert.ToInt32(Math.Pow(10, x));

if (count >= 3 && m2 > 0);
{
    int m = (c / m2);
    int mi = (m % 10);
    Console.WriteLine($"Разрядность числа: {count}");
    Console.WriteLine($"Искомое число: {mi}");
} 



