// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(51);
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");


void ReversedRecursion(int[] arr, int start = 0)
{
    if (start != arr.Length)
    {
        ReversedRecursion(arr, start + 1);
        Console.Write($"{array[start]}  ");
    }
}
Console.Write("Рекурсия массива:  ");
ReversedRecursion(array);