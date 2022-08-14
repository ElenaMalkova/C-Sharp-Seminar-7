// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Method


int[,] GetArray(int m, int n, int min, int max)
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

void PrintArray(int[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write($"{localArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindColumnAverage(int[,] arr)
{
    
    int size = arr.GetLength(1);
    int[] average = new int[size];

    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        int columnAverage = sum / arr.GetLength(0);
        average[j] = columnAverage;
    }
    return average;
}

//Code

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns, 0, 11);
Console.WriteLine("Ваш массив:");
PrintArray(myArray);

Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: \n{0}", String.Join( "\t", FindColumnAverage(myArray)) );

