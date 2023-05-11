// Одномерный массив. Заполнен рандомом
/*
Console.Clear();
int[] m1 = new int[5];
Random random = new Random();
for (int i = 0; i < m1.Length; i++)
    {
        m1[i] = random.Next(1, 11);
        Console.Write(m1[i].ToString() + " ");

        
    }

*/

/*
// Рандомная матрица
Console.Clear();
Random random = new Random();
int a = random.Next(3, 9);
int b = random.Next(3, 9);
int[,] matrix = new int[a, b];
for (int i = 0; i < a; i++)
{
  
 for (int j = 0; j < b; j++)
 {
    matrix[i, j] = random.Next(0, 9);
    Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
*/
/* 
// Ещё более рандомная матрица!
Console.Clear();
Random random = new Random();
int a = random.Next(3, 9);
int b = random.Next(3, 9);
int[,] matrix = new int[a, b];

for (int z = 0; z < a; z++) {
    for (int i = 0; i < a; i++)
    {
    
    for (int j = 0; j < b; j++)
    {
        matrix[i, j] = random.Next(0, 9);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
    }
}
*/
/*
// Попытка инвертировать двухмерный массив
Console.Clear();
Random random = new Random();
int[,] matrix = new int[3, 3];
for (int i = 0; i < 3; i++)
{
  
 for (int j = 0; j < 3; j++)
 {
    matrix[i, j] = random.Next(0, 2);
    Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}

Console.WriteLine();

int[,] matrix2 = new int[3, 3];
    for (int z = 0; z < 3; z++)
    {
    
    for (int y = 0; y < 3; y++)
    {
        if (matrix[i, j] = 0)
           
            {
                 matrix2[z, y] = (matrix[i, j] +1);
                z++; 
                y++; // Добавляем элементы в массив m2
              
            }
        Console.Write($"{matrix2[z, y]} ");
    }
Console.WriteLine();
}
*/

/*
// Инвертировал одномерный массив!

Console.Clear();
int[] m1 = new int[5];
int[] m2 = new int[5];
Random random = new Random();
for (int i = 0; i < m1.Length; i++)
    {
        m1[i] = random.Next(0, 2);
        Console.Write(m1[i].ToString() + " ");
    }
    Console.WriteLine();

        int j = 0; 

        for (int i = 0; i < m1.Length; i++)
        {
            if (m1[i] > 0)
            {
                m2[j] = 0; 
                j++;  
            }
            if (m1[i] < 1)
            {
                m2[j] = 1; 
                j++;  
            }
             Console.Write(m2[i].ToString() + " ");
        }
*/



// Рандомная матрица
Console.Clear();
Random random = new Random();
int[,] matrix = new int[3, 3];
for (int i = 0; i < 3; i++)
{
  
 for (int j = 0; j < 3; j++)
 {
    matrix[i, j] = random.Next(0, 2);
    Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
Console.WriteLine();

int[,] matrix2 = new int[3, 3];
for (int z = 0; z < 3; z++)
{
  
 for (int y = 0; y < 3; y++)
 {
    if (matrix[i, j] < 1)
    {
        matrix2[z, y] == 0;
        y++;
    }
    Console.Write($"{matrix2[z, y]} ");
 }
Console.WriteLine();
}
