// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// start = M, end = N
string PrintNumbers(int start, int end)
{
    if (N < M) throw new ArgumentException("N - должна быть больше M");
    if (start == end) return start.ToString();
    return start + " " + PrintNumbers(start + 1, end);
}
Console.WriteLine($"Печать чисел от {M} до {N} = {PrintNumbers(M, N)}");
