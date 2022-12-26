//  Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.WriteLine("Input the natural number is more 1:");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} not the natural number");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
*/

// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
/*
Console.WriteLine("Input an initial number M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Input a finite number N:");
int numberN = int.Parse(Console.ReadLine());
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"The sum of natural elements in the range from M to N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
/*
Console.Write("Input number  M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/