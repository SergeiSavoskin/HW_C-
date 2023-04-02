// Ввод чисел

/*
Console.Clear();
// int n = convert.ToInt32(Console.Readline());
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n * 3);
*/
/*
Программный код
Hollo World!
*/

// Спросить два числа и узнать какое больше
// 1 > 2
// 2 > 1
// 2 = 1
/*
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
// Интерполяция строк
// Console.WriteLine($"Рузультат: {a} + {b} = {a + b}");
// Проверка на равенство
// Console.WriteLine(a > b);
if (a > b)
    Console.WriteLine(a);
else if (a < b)
    Console.WriteLine(b);
else
    Console.WriteLine("=");
*/
// for (begin; end; step)
// i++ <=> i = i + 1

/*
for(int i = 1; i <= 10; i++)
    Console.Write($"{i} ");
Console.WriteLine();
for(int i = 1; i <= 10; i+=2)
    Console.Write($"{i} ");
Console.WriteLine();
for(int i = 10; i > 0; i--)
    Console.Write($"{i} ");
*/
 // Возвести число в квадрат

/* Задание № 1 - сравниение первого числа и квадрата второго
Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
int c = b * b;
Console.WriteLine($"Квадрат числа 2 равен: {c}");

if (a == c)
    Console.WriteLine("Да!");

else if (a < c)
    Console.WriteLine("Первое число меньше квадрата второго");
else if (a > c)
Console.WriteLine($"Первое число равно {a} и явно больше квадрата второго {c}");
*/

/* Зажание № 2 - вывод дня недели по заданому номеру 
Console.Clear();
Console.Write("Введите день недели: ");
int a = int.Parse(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.Write("Вы ошиблись! \nВведите день недели!\n");
    a = int.Parse(Console.ReadLine());
}

if (a == 1)
    Console.WriteLine("Понедельник!");
else if (a == 2)
    Console.WriteLine("Вторник!");
else if (a == 3)
    Console.WriteLine("Среда!");
else if (a == 4)
    Console.WriteLine("Четверг!");
else if (a == 5)
    Console.WriteLine("Пятница!");
else if (a == 6)
    Console.WriteLine("Суббота!");
else if (a == 7)
    Console.WriteLine("Воскресенье!");
    */

    int ii = Convert.ToInt32(Math.Pow(10, -3));

Console.WriteLine(ii);