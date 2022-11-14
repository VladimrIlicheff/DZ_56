/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m, n);
int GetNumber(string message)

{

    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}      ");
        }
        Console.WriteLine();
    }
}

void MinSumRange(int[,] array)
{
    int minRange = 0;
    int minSumRange = 0;
    int sumRange = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRange += matrix[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRange += matrix[i, j];
        if (sumRange < minRange)
        {
            minRange = sumRange;
            minSumRange= i;
        }
        sumRange = 0;
    }
    Console.Write($"{minSumRange + 1} строка");
}
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("- - - - - - - - ");   
Console.WriteLine();
SumMinRange(matrix);
Console.WriteLine();

