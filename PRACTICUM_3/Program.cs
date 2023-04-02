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

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послади вместо нашего милого Винценгерое,"
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

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

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//далее идёт метод, который будет упорядочивать
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for(int j = i+ 1; j < array.Length; j++) //ищем максиальный элемент
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporay = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporay;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);