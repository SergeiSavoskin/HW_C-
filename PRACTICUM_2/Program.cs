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

/*Максимальное из 9-ти чисел с помощью функции

Console.Clear();

int Max(int arg1, int arg2, int arg3)

{
    int result = arg1;
    if(arg2 > result) result = arg2;  // Тело метода!
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 1222;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);

Console.WriteLine(max);
*/

/*Максимальное из 9-ти чисел с помощью массива 

Console.Clear();

int Max(int arg1, int arg2, int arg3)

{
    int result = arg1;
    if(arg2 > result) result = arg2;  // Тело метода!
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])

);
Console.WriteLine(result);
*/

/*Поиск нужного элемента 
Console.Clear();
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
*/

/*Поиск нужного элемента - используем продвинутый синтаксис 

Console.Clear();
void  FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
*/
/*Поиск нужного элемента с помощью методов

Console.Clear();
void  FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int Index0f(int[] collection, int fiend)
{

    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == fiend)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = Index0f(array, 444);
Console.WriteLine(pos);
*/

/*Задача №11 Удаляем вторую цифру трёхзначного числа
Console.Clear();
int n = new Random().Next(100, 1000); // [10, 99]
Console.WriteLine($"Случайное сгененрированное число: {n}");
int n1 = n / 100;
int n2 = n % 10;
int n3 = (n1*10 + n2);


    Console.WriteLine($"n1: {n1}");
    Console.WriteLine($"n2: {n2}");
    Console.WriteLine($"Искомое число: {n3}");
*/

/*Задача 12 Принимать на вход два числа и выводить
 является ли второе число кратным первому. 
 Если число 2 не кратно числу 1, то программа выводит остаток от деления

Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
int c = (a % b);

if (c == 0) 
{
    Console.WriteLine("Число 2 кратно числу 1");
}

else 
{
    Console.WriteLine($"Остаток от деления: {c}");
}
*/

/*Задача 14 Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

//int c = (a % 161);

if ( n % 7 == 0 && n % 23 == 0)                               // || - ИЛИ
                                                              // && - И
{
    Console.WriteLine("Это число кратно одновременно 7 и 23");
}

else 
{
    Console.WriteLine($"Не кратно");
}
*/

/*Задача 16. Принимает на вход два числа и проверяет, 
является ли одно квадратом второго*/

Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
if (a == b*b || b == a*a) 
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Здесь нет квадратов..");
}
