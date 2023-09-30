﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Введите первое число для вычисления функции Аккермана: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число для вычисления функции Аккермана: ");
int num2 = int.Parse(Console.ReadLine());
int akkerman = Akkerman(num1, num2);
Console.Write("Функция Аккермана равна: ");
Console.WriteLine(akkerman);
