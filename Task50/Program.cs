// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

//метод ищет позицию.

int SearchElement(int[,] matrix, int row, int column)
{
    row--;
    column--;
    int element = matrix[row, column];
    return element;
}

//ПРОГРАММА

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);


Console.Write("Введите строку позиции, которую хотие вывести: ");
int numRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колонку позиции, которую хотие вывести: ");
int numColumn = Convert.ToInt32(Console.ReadLine());

//проверка ввода.
if (numRow > array2D.GetLength(0) || numColumn > array2D.GetLength(1) || numRow <= 0 || numColumn<=0)
{
    Console.WriteLine("Такого элемента в массиве нет");
    return;
}

//Вывод результата.
int elementmatrix = SearchElement(array2D, numRow, numColumn);
Console.WriteLine(elementmatrix);