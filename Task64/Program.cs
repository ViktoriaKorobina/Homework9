// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ShowNumbers(int num)
{
    if(num == 1) return $"{num} ";
    else return $"{num} " + ShowNumbers(num - 1); 
}
int number = 7;
System.Console.WriteLine("Ввывод чисел от {0} до 1 в обратном порядке", number);
Console.WriteLine(ShowNumbers(number));
