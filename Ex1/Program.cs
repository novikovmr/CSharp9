/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


int InputValue(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output; 
}

void ShowNumbers(int n)
{
    Console.Write($"{n}, ");
    if (n > 1) ShowNumbers(n - 1);
}

void ShowNumbersReverse(int n)
{
    if (n > 1) ShowNumbersReverse(n - 1);
    Console.Write($"{n}, ");
}

int n = InputValue("Введите значение N: ");
ShowNumbers(n);
Console.WriteLine();
ShowNumbersReverse(n);