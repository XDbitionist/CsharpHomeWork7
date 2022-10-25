/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 50);
        }
    }
}
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите координаты А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B");
int b = Convert.ToInt32(Console.ReadLine());
if (a >= m && b >= n)
    Console.WriteLine("Такого числа в массиве нет");
else if (a < m && b >= n)
    Console.WriteLine("Такого числа в массиве нет");
else if (a >= m && b < n)
    Console.WriteLine("Такого числа в массиве нет"); 
else
{
    object c = array.GetValue(a, b);
    Console.WriteLine($"Число, которое находится в массиве по заданным координатам: {c}");
} 