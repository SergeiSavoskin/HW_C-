/*Напишите программу, которая выводит случайное число на отрезке от 10 до 99 
и указывает наибольшую цифру числа

Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine($"Случайное сгененрированное число: {n}");
int n1 = n / 10;
int n2 = n % 10;

if(n1 > n2)
    Console.WriteLine(n1);
else //В остальных случаях!
    Console.WriteLine(n2);
 */