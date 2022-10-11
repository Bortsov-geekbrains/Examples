/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

int a = 0;
int b = 0;
int pow = 1;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);
for (int i = 0; i < b; i++) {
        pow *= a;
    }
Console.Write($"Возведение число A в натуральную степень B = {pow}");       
return 0;

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

int a = 0;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
int s = 0;
    while (a > 0)
        {
            s = s + a % 10;
            a = a /10 ;
 
        }
 Console.Write($"Сумма цифр в числе = {s}"); 

Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

int i;
int[] a = new int[10];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 10; i++)

a[i] = int.Parse(Console.ReadLine());

Console.WriteLine("[{0}]", string.Join(", ", a));
/*       **Задача 31:** 
Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.        

int[] array = CreateArray(12, -9, 10);

int sumP = 0;
int sumN = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sumP += array[i];
    else
        sumN += array[i];
}

PrintArray(array);
Console.Write($"\n{sumP} {sumN}");

int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    foreach (var item in _array)
        Console.Write($"{item} ");
}

      **Задача 32:** 
Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]        

int[] array = CreateArray(10, -9, 10);

PrintArray(array);

for (int i = 0; i < array.Length; i++)
    array[i] *= -1;

PrintArray(array);




// Методы массивов
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
    Console.WriteLine();
}
/* 
/*       **Задача 33:** Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да      

int[] array = CreateArray(10);

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

PrintArray(array);

if (FindNumber(array, a))
    Console.Write($"Существует");
else
    Console.Write($"Несуществует");

bool FindNumber(int[] _array, int _a)
{
    for (int i = 0; i < _array.Length; i++)
        if (_array[i] == _a)
            return true;
    return false;
}

// Методы массивов
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
    Console.WriteLine();
}
*/
/*       **Задача 35:** Задайте одномерный массив случайных чисел до 123. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5        

int[] array = CreateArray(10, 0, 123);

PrintArray(array);

int count = 0;

foreach (int item in array)
{
    if (item >= 10 && item <= 99)
        count++;
}

Console.Write($"{count}");

// Методы массивов
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
    Console.WriteLine();
}
*/
/*       **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21        

int[] array = CreateArray(new Random().Next(4, 11));

int lengthA = 0;
if (array.Length % 2 != 0)
    lengthA = array.Length / 2 + 1;
else
    lengthA = array.Length / 2;

int[] newArray = new int[lengthA];

PrintArray(array);

for (int i = 0, z = array.Length - 1; i < array.Length; i++, z--)
{

    if (z < i)
        break;
    else if (z == i)
    {
        newArray[i] = array[i];
        break;
    }
    newArray[i] = array[i] * array[z];
}

PrintArray(newArray);

// Методы массивов
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        C
/*       **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21        

int[] array = CreateArray(new Random().Next(4, 11));

int lengthA = 0;
if (array.Length % 2 != 0)
    lengthA = array.Length / 2 + 1;
else
    lengthA = array.Length / 2;

int[] newArray = new int[lengthA];

PrintArray(array);

for (int i = 0; i < lengthA; i++)
{
    if (i == array.Length - i - 1)
        newArray[i] = array[i];
    else
        newArray[i] = array[i] * array[array.Length - i - 1];
}

PrintArray(newArray);

// Методы массивов
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write(

List<int> list = new List<int>(); // Динамический список

int a;
int.TryParse(Console.ReadLine()!, out a);
list.Add(a);

while (a != 0)
{
    int.TryParse(Console.ReadLine()!, out a);
    list.Add(a);
}
*/