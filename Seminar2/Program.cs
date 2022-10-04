


/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


Console.Write("Введите число = ");             
int _a = int.Parse(Console.ReadLine());
int number2 = ( _a % 100) / 10;
Console.Write($" Искомое число {number2}, ");


Console.Write("Введите число = ");             
int _a = int.Parse(Console.ReadLine());
int number2 = (_a / 10) % 10;
Console.Write($" Искомое число {number2}, ");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
Так как задача с подвохом - так как неопределено с какой стороны искать
Первый вариант - поиск справо - налево

Console.Write("Введите число = ");             
int _a = int.Parse(Console.ReadLine());
if (_a > 99)
{
    Console.WriteLine(( _a / 100) % 10);
}
else
{
    Console.Write($" Число не содержит третью цифру {_a}, ");
}
//
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "Нет третьей цифры" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.Write("Введите число от 1 до 7:");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 7)
    {
        if (number == 6 | number == 7) Console.WriteLine("Сегодня выходной");
        else Console.WriteLine("Сегодня рабочий день");
    }
else Console.WriteLine("Не верное число");

*/