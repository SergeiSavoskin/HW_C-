﻿
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"{a} больше {b}");
else if (a < b)
    Console.WriteLine($"{a} меньше {b}");
else
    Console.WriteLine("Вах! Эти числа саверщенно равны!");
*/

/* Задача 4. Выдать наибольшее из трёх чисел
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное число:  {max}");
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 

Console.Clear();
Console.Write("Введите ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно");
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите ваше положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i <= N)
{
    Console.Write($"{i} ");
    i = i + 2;
}
 */