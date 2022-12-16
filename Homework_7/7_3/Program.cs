// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int MinRndm = -9;
int MaxRndm = 99;

// Creates an rows*columns 2d array of pseudo-random integers in range[MinRndm, MaxRndm].
int[,] Array2Dimensional(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MinRndm, MaxRndm);
    }
    return mass;
}

// Print to console values of the array
void Display2dArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 6}  ");
        Console.Write('\n');
    }
}

// Print to console mean of each column in 2d arr.
void MeanofColumns(int[,] arr) {
    double mean = 0.0;
    for (int i = 0, j = 0; i < arr.GetLength(1); i++) {
        for (j = 0, mean = 0; j < arr.GetLength(0); j++) mean += arr[j, i];
        Console.Write($"{Math.Round(mean / j, 2), 6}; ");
    }
    Console.Write('\n');
}

int ROWS = 3;
int COLUMNS = 4;

int[,] array = Array2Dimensional(ROWS, COLUMNS);
Console.WriteLine("задан массив:");
Display2dArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
MeanofColumns(array);
