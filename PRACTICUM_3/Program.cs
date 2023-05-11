/* 
// Вид 1
void Method1() // Method1 - идентификатор
{
    Console.WriteLine("Автор ФИО");
}

Method1(); // вызов метода 

*/

/*

// Вид 2 ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg) 
 // void - Ключевое слово, Method2 - идентифкатор, string msg -аргументы
 {
    Console.WriteLine(msg);
 }

 // Для того, что бы вызвать подобного рода метод, требуется указать идентификатор

 // Method2("Текст сообщения");


*/

/*

void Method21(string msg, int count) 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", counnt: 4);
Method21(count: 4 , msg: "Новый текст");

*/ 

/*
// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

*/

// Вид 4. Что-то принимают и что-то возвращают
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // Изначально пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

*/

// Циклы

/*

string Method4(int count, string text)
{

    string result = String.Empty;  
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);
*/
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буква "к" заменить большими "К", а большие "С" заменить на маленькие "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//                 + "ежели бы вас послади вместо нашего милого Винценгерое,"
//                 + "вы бы взяли приступом согласие прусского короля. "
//                 + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r
/*
string Replace(string text, char oldvalue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldvalue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

*/

//Сортировка выборам махкса или мина

// 1. Найти позицию минимального элемента в неотсортированой части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// //далее идёт метод, который будет упорядочивать
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1 ; i++)
//     {
//         int minPosition = i;
        
//         for(int j = i+ 1; j < array.Length; j++) //ищем максиальный элемент
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
        
//         int temporay = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporay;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

// Console.Clear();
// Console.WriteLine("Введите нужное число");
// string s = Console.ReadLine()!;
// int sum = 0;
// // Напишите программу, которая будет находить сумму цифр числа
// for (int i = 0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine(sum);


// // Необходимо сложить 2 числа с помощью рекурсии
// // 5 6 -> 11
// int f(int a, int b)
// {
//   if (a == 0)
//     return b;
//   return f(a - 1, b + 1);
// }

// Console.Clear();
// Console.WriteLine(f(5, 3));

// // f(5, 3) -> f(4, 4) -> f(3, 5) -> f(2, 6) -> f(1, 7) -> f(0, 8) -> 8



// string f(int n)
// {
//   if (n == 1)
//     return "1 ";
//   return f(n - 1) + $"{n} "; // return $"{n} + f(n - 1)";
//   //return $"{n} + f(n - 1)";
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));
// /*
// f(5) -> f(4) + "5 "
//           |
//           f(3) + "4 "
//             |
//             f(2) + "3 "
//               |
//               f(1) + "2 "
//                 |
//                 "1 "
// */


// //Вывести все натуральные числа в промежутке между M и N
// Console.Clear();
// Console.WriteLine("Введите M");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите N");
// int n = int.Parse(Console.ReadLine()!);
// int f(int n, int m)
// {
//   if (m == n)
//     return (N);
//     return f(n, m - 1) + $"{n} ";
// }

/// От препода ВЫВОД ВСЕХ НАТУРАЛЬНЫХ ЧИСЕЛ ОТ M до N

// string f(int a, int b)
// {
//   if (a == b)
//     return $"{a} ";
//     return f(a, b - 1) + $"{b} ";
// }
// Console.Clear();
// Console.Write("Введите начальное число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конечное число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(m, n));



// int f(int n)
// {
//   if (n < 10 || n / 10 == 0 || n % 10 == n)
//     return n;
//   return f(n / 10) + n % 10;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(f(n));
// /* 
// f(12345) -> f(1234) + 5
//                 |
//                 f(123) + 4
//                   |
//                   f(12) + 3
//                     |
//                     f(1) + 2
//                       |
//                       1
// */
/*
int f(int a, int b)
{
  if (b == 0)
    return 1;
    return f(a, b - 1) * a;
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));

*/

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = { 1, 2, 3, 4, 5 };
//         string[] names = new string[3] { "John", "Mary", "Tom" };
        
//         Console.WriteLine("The first number is " + numbers[0]);
//         Console.WriteLine("The second name is " + names[1]);
//     }
// }


using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        string[] names = new string[3] { "John", "Mary", "Tom" };
        
        Console.WriteLine("The first number is " + numbers[0]);
        Console.WriteLine("The second name is " + names[1]);
    }
}