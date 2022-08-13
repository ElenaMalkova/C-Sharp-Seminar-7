// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
//Methods

int [,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray (int [,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write ($"{localArray[i, j]} \t");
        }
    Console.WriteLine();
    }
}

//Code

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());
int [,] myArray = GetArray(rows, columns, 0, 101);
Console.WriteLine("Ваш массив:");
PrintArray(myArray);

