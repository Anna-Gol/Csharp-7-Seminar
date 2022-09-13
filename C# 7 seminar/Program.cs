// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Array()
{

    Console.Write("Введите число строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-10, 10));

            Console.Write($"{array[i,j]:f1} ");
        }

    Console.WriteLine();
    }

}
Array();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void ArrayPosition()
{
    int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

    Console.Write("Введите позицию элемента: ");
    int p = Convert.ToInt32(Console.ReadLine());

    if (p / 10 < array.GetLength(0) && p % 10 < array.GetLength(1))
    {
        Console.Write($"Значение элемента = {array[p / 10, p % 10]}");
    }

    else 
    {
         Console.Write("такого числа в массиве нет");
    }
}

ArrayPosition();


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArMean()
{
    int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double aver = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
            aver = sum / array.GetLength(0);
            
        }
        Console.Write($"{aver:f1}; ");
    }
}

ArMean();