


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
/*
int x = 0, y = 0;
Console.Write($"Введите координату X: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите координату Y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0)
{
    if (y > 0)
        Console.Write("Плоскость 1");
    else if(y < 0)
        Console.Write("Плоскость 4");
    else
        Console.Write("Точка лежит на оси X");
}
else if(x < 0)
{
    if(y > 0)
        Console.Write("Плоскость 2");
    else if(y < 0)
        Console.Write("Плоскость 3");
    else
        Console.Write("Точка лежит на оси X");
}
else
{
    if (y == 0)
        Console.Write("Точка лежит на начале коррдинат");
    else
        Console.Write("Точка лежит на оси Y");
}

int[] A = new int[2];
int[] B = new int[2];
Console.Write($"Введите координату X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);

double c = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2));

Console.Write($"Расстояние между точками = {c}");
*/
/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).


int a = 0;
Console.Write($"Введите координатную четверть: ");
int.TryParse(Console.ReadLine()!, out a);

switch (a)
{
    case 1:
        Console.Write($"X > 0  Y > 0");
        break;
    case 2:
        Console.Write($"X < 0  Y > 0");
        break;
    case 3:
        Console.Write($"X < 0  Y < 0");
        break;
    case 4:
        Console.Write($"X > 0  Y < 0");
        break;
    default:
        Console.Write($"Неверный ввод!");
        break;
}


int a = 0;
Console.Write($"Введите координатную четверть: ");
int.TryParse(Console.ReadLine()!, out a);
if(isPal(a) == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
 */