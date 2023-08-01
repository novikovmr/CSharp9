/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int InputValue(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output; 
}


int SummElements(int m, int n)
{
    if (Math.Min(m, n) < Math.Max(m, n)) return Math.Min(m, n) + SummElements(Math.Min(m, n)+1, Math.Max(m, n));
    else return Math.Max(m, n);
}

Console.Clear();

int m = InputValue("Введите значение M: ");
int n = InputValue("Введите значение N: ");
Console.WriteLine($"{SummElements(m, n)}");