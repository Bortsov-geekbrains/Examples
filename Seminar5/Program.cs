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