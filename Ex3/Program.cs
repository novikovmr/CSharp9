/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/



int InputValue(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output; 
}


int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunc(m-1, 1);
    else if (m > 0 && n > 0) return AckermanFunc(m - 1, (AckermanFunc(m, n - 1)));
    else return 0;
}
// A(m-1A(m, n-1))

Console.Clear();
int m = InputValue("Введите значение m >= 0: ");
int n = InputValue("Введите значение n >= 0: ");

Console.WriteLine(AckermanFunc(m, n));