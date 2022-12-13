// Задайте двумерный массив. Найдите элементы, у которых обе позиции четные,
// замените эти элементы на их квадраты.

int MinRndm = -9;
int MaxRndm = 9;

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

void SetSqureToEvenPos(int[,] arr) {
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 1; i < rows; i += 2) {
        for (int j = 1; j < columns; j += 2) arr[i, j] *= arr[i, j];
    }
}

int[,] array = Get2dArray(6, 6);
Display2dArray(array);
Console.WriteLine("=================");
SetSqureToEvenPos(array);
Display2dArray(array);
