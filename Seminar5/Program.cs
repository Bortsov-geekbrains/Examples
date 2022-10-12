/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int[] array = CreateArray(10, 99, 999);

PrintArray(array);

int count = 0;

foreach (int item in array)
{
    if (item %2 == 0)
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

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

int[] array = CreateArray(10, 0, 20);

PrintArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i];

    Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");

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
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

int size = 0;
Console.WriteLine("Введите размер массива");
int.TryParse(Console.ReadLine()!, out size);
double[] array = new double[size];
CreateArray(array);
Console.WriteLine("Вот наш массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");



// Методы массивов
void CreateArray(double[] _array)
{
    for(int i = 0; i < _array.Length; i++)
        {
            _array[i] = Convert.ToDouble(new Random().Next(1,25));
        }
}

void PrintArray(double[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
Двухмерные массивы
int[,] array2 = new int[2, 3] { { 1, 2, 3 }, { 3, 2, 1 } };

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array2[i, j] = new Random().Next(10);
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}

foreach (var item in array2)
{
    Console.Write($"{item} ");
}

int[,] array2 = new int[3, 5];

for (int i = 0; i < array2.GetLength(0); i++) // Строка
{
    for (int j = 0; j < array2.GetLength(1); j++) // Столбец
    {
        array2[i, j] = new Random().Next(10);
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}

foreach (var item in array2)
{
    Console.Write($"{item} ");
}


/*     **Задача 39:** Напишите программу, которая перевернёт одномерный 
                    массив
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]    

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[array.Length - i - 1];
    array[array.Length - i - 1] = array[i];
    array[i] = temp;
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

/*     **Задача 39:** Напишите программу, которая перевернёт одномерный 
                    массив
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]    

int[] array = new int[5];
int[] array2 = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length; i++)
    array2[i] = array[array.Length - i - 1];

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array2[i]} ");

/*     Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.    

int[] array = new int[] { 4, 5, 7 };

if (TriangleSuccess(array[0], array[1], array[2]))
    Console.Write($"Треугольник существует");
else
    Console.Write($"Треугольник не существует");

bool TriangleSuccess(int a, int b, int c)
{
    return (a + c) > b && (b + c) > a && (a + b) > c;
}
*/
/*     **Задача 42:** Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10    

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int temp = a;
string doub = "";

while (temp > 0)
{
    doub += (temp % 2).ToString();
    temp /= 2;
}

char[] doubT = doub.ToCharArray();

Array.Reverse(doubT);

Console.Write(doubT);

/*     **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8    

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

if (N < 2)
    N = 2;

int[] array = new int[N];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < N; i++)
    array[i] = array[i - 2] + array[i - 1];

foreach (var item in array)
    Console.Write($"{item} ");

/*     **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8    

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);


int a = 0;
int b = 1;

Console.Write($"{a} {b} ");

for (int i = 2; i < N; i++)
{
    int c = a + b;
    Console.Write($"{c} ");
    a = b;
    b = c;
}