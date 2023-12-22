// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Ackermann(int N, int M)
{
    if (N < 0 || M < 0) throw new ArgumentException("Функция только для положительных чисел!");
    if (N == 0) return M + 1;
    if (M == 0) return Ackermann(N - 1, 1);
    return Ackermann(N - 1, Ackermann(N, M - 1));
}
Console.WriteLine($"Функция Аккермана для чисел: {N} и {M} = {Ackermann(N, M)}");
