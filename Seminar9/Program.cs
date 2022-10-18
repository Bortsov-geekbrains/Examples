/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number;
Console.WriteLine("Введите натуральное число больше 1:");
int.TryParse(Console.ReadLine()!, out number);

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int _number)
{
    if (_number < 0) Console.Write($"{_number} не натуральное число");
    if (_number == 0) return;
    Console.Write("{0,4}", _number);
    NumberCounter (_number - 1);
}

NumberCounter(number);


Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int M;
int N;
Console.Write("M = ");
int.TryParse(Console.ReadLine()!, out M);
Console.Write("N = ");
int.TryParse(Console.ReadLine()!, out N);
Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
Console.ReadLine();
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

int n;
int m;
int.TryParse(Console.ReadLine()!, out m);
int.TryParse(Console.ReadLine()!, out n);

Console.Write(Ack(m, n)); // вызов рекурсивной функции    

static int Ack(int _m, int _n)
{
    if (_m == 0) return _n + 1;

    else if (_n == 0) return Ack(_m - 1, 1);

    else return Ack(_m - 1, Ack(_m, _n - 1));

}
*/






