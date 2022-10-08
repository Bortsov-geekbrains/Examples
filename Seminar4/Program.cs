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

 
for (i = 0; i < 10; i++)

Console.WriteLine(a[i]);
*/