// Задайте двумерный массив. Напишите программу, которая меняет местами первую
// и последнюю строку.

int MinRndmValue = -9;
int MaxRndmValue = 9;

// Creates an rows*columns 2d array of pseudo-random integers in range[MinRndmValue, MaxRndmValue]
int[,] Array2d(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MinRndmValue, MaxRndmValue);
    }
    return mass;
}

// Display values of the 2d array
void Display2dArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j], 4} ");
        Console.Write('\n');
    }
}

// Swaps the values of the first and last rows of a 2d array.
void SwapRows(int[,] arr) {
    int row = arr.GetLength(0);
    for (int i = 0; i < arr.GetLength(1); i++) (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
}

int rows = 3;
int columns = 4;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
SwapRows(array);
Console.WriteLine("=============");
Display2dArray(array);
