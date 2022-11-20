// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//МЕТОДЫ
//метода создает массив из произвольных чисел.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//метод печатает массив.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

//метод расчитывет среднее арифметическое столбцов двухмерного массива и результат помещает в одномерный массив.
double[] ArithmeticMean(int[,] matrix)
{
    double[] arithmeticMean = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        double num;
        double resultArith;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            num = matrix[i, j];
            //Console.Write($"{sum}, ");
            sum+= num;
        }
        resultArith = sum / matrix.GetLength(0);
        resultArith = Math.Round(resultArith, 1);
        arithmeticMean[j] = resultArith;
    }

    return arithmeticMean;
}

//метод печатает одномерный массив.
void PrintArray(double[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    //Console.Write("] ");
}

//ПРОГРАММА
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

double[] array = ArithmeticMean(array2D);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(array);