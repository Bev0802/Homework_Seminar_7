// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//МЕТОД
//метода создает двухмерный массив заполненный вещественными числами.
double[,] CreateMatrixRndDouble(int rows, int columns,  double min, double max)
{
    double[,] matrix = new double[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min; // создаем число массива в заданном диапазоне
            matrix[i, j] =  Math.Round(num, 1);
        }
    }
    return matrix;
}

//метод печтатает двухмерный массив.
void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

//ВЫВОД РЕЗУЛЬТАТА
double[,] array2D = CreateMatrixRndDouble(3, 4, -10, 10);
PrintMatrixDouble(array2D);

