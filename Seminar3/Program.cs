/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = number / 100;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

double [] x = new double [6];
double d, distance = 0.0;
Console.WriteLine("x1 y1 z1 x2 y2 z3:");
var line = Console.ReadLine().Split();
for (int i = 0; i < 3; i++)
{ d = Convert.ToDouble(line[i + 3])
- Convert.ToDouble(line[i]);
distance += d * d; }
Console.WriteLine("r = " + Math.Sqrt(distance)); 

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

int N = 0;
Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine()!, out N);
for (int i = 1; i <= N; i++)
{
    Console.WriteLine("{0}^3 = {1}", i, i*i*i);
}
*/