/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

int n = 0;
int m = 0;
Console.WriteLine("введите количество строк");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine("введите количество столбцов");
int.TryParse(Console.ReadLine()!, out n);
double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

int n = 0;
int m = 0;
Console.WriteLine("введите номер строки");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine("введите номер столбца");
int.TryParse(Console.ReadLine()!, out m);
int [,] numbers = new int [3,5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int n = 0;
int m = 0;
Console.WriteLine("введите количество строк");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine("введите количество столбцов");
int.TryParse(Console.ReadLine()!, out m);

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/
/*         **Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2            

int m = 6, n = 7;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(1); i++)
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}
*/
/*         **Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2             

int m = 6, n = 7;

List<List<int>> list = new List<List<int>>();

for (int i = 0; i < m; i++)
{
    list.Add(new List<int>());
    for (int j = 0; j < n; j++)
    {
        list[i].Add(new Random().Next(10));
        Console.Write($"{list[i][j]} ");
    }
    Console.WriteLine();
}

List<int> temp = list[0];
list[0] = list[list.Count - 1];
list[list.Count - 1] = temp;

Console.WriteLine();
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list[i].Count; j++)
        Console.Write($"{list[i][j]} ");
    Console.WriteLine();
}
*/

/*        **Задача 55:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7                    
int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n);
Console.WriteLine();
//int[,] array2 = new int[n, m];

for (int i1 = 0; i1 < m; i1++)
{
    for (int j1 = 0; j1 < n; j1++)
    {
        int k = 0;
        int temp = array[i1, j1];
        if (temp != -1)
        {
            for (int i2 = 0; i2 < m; i2++)
            {
                for (int j2 = 0; j2 < n; j2++)
                {
                    if (temp == array[i2, j2])
                    {
                        array[i2, j2] = -1;
                        k++;
                    }
                }
            }
            Console.Write($"{temp} встречается {k} раз\n");
        }
    }
}



int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n);
Console.WriteLine();
//int[,] array2 = new int[n, m];

List<int> temp = new List<int>();
foreach (var item in array)
{
    if (!temp.Contains(item))
        temp.Add(item);
}

temp.Sort();

foreach (var item in temp)
{
    int count = 0;
    foreach (var item2 in array)
    {
        if (item == item2)
        {
            count++;
        }
    }
    Console.WriteLine($"{item} встречается раз - {count}");
}


int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n);
Console.WriteLine();
int[] array2 = new int[10];

foreach (var item in array)
{
    array2[item]++;
}

for (int i = 0; i < array2.Length; i++)
    if (array2[i] != 0)
        Console.Write($"{i} встречается {array2[i]} раз\n");


int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n, 90, 100);
Console.WriteLine();


int max = array[0, 0];
int min = array[0, 0];


foreach (var item in array)
{
    if (max < item)
        max = item;
    if (min > item)
        min = item;
}
int[] array2 = new int[max + 1 - min];

foreach (var item in array)
{
    array2[item - min]++;
}

for (int i = 0; i < array2.Length; i++)
    if (array2[i] != 0)
        Console.Write($"{i + min} встречается {array2[i]} раз\n");

*/