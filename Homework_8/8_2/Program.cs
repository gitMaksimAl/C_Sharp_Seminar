// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

int MinRndmValue = 0;
int MaxRndmValue = 12;

// Creates an rows*columns 2d array of pseudo-random integers in
// range[MinRndmValue, MaxRndmValue].
int[,] Array2d(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MinRndmValue, MaxRndmValue);
    }
    return mass;
}

// Display values of the 2d array.
void Display2dArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 4} ");
        Console.Write('\n');
    }
}

// Returns the position of the row in 2d integer array with the smallest sum
// of values.
int GetSmallestRow(int[,] arr) {
    int sum, row;
    sum = row = 0;
    int minimal = System.Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++) {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];
        if (sum < minimal) {
            minimal = sum;
            row = i + 1;
        }
    }
    return row;
}

int rows = 3;
int columns = 4;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
Console.WriteLine($"{GetSmallestRow(array)} row is lightest.");
