// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double[m,n];
for (int i = 0; i < m; i++)
{  
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-1000,1000)/10.0;
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}