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
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n * n);