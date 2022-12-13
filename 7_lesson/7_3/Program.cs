// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int MinRndm = 1;
int MaxRndm = 12;

// creates an rows*columns 2d array of pseudo-random integers in range[MinRndm, MaxRndm]
int[,] Get2dArray(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MinRndm, MaxRndm);
    }
    return mass;
}

// display values of the 2d array
void Display2dArray(int[,] arr) {
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        int j = 0;
        for (; j < columns - 1; j++) Console.Write($"{arr[i, j], -3}, ");
        Console.WriteLine(arr[i, j]);
    }
}

int SumDiagonal(int[,] arr) {
    int sum = 0;
    int rows = arr.GetLength(0);
    for (int i = 0; i < rows; i++) sum += arr[i, i];
    return sum;
}

int[,] array = Get2dArray(4, 4);
Display2dArray(array);
Console.WriteLine("=================");
Console.WriteLine($"sum = {SumDiagonal(array)}");
