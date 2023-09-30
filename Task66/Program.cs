// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfNumbers(int m, int n)
{
    if(m == n) return m;
    else return m + SumOfNumbers(m + 1, n);
}
Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
int sum;
if(firstNum < secondNum) sum = SumOfNumbers(firstNum, secondNum);
else sum = SumOfNumbers(secondNum, firstNum);
Console.Write("Сумма элементов равна: ");
Console.WriteLine(sum);