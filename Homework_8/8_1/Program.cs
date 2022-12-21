// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int MinRndmValue = -9;
int MaxRndmValue = 9;

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

// Sorting each row in a 2d array by sorting implementation.
void Sort2dArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        // Bubble sort implementation.
        int len = arr.GetLength(1) - 1;
        while (len > 0) {
            for (int j = 0; j < len; j++) {
                if (arr[i, j + 1] > arr[i, j])
                    (arr[i, j], arr[i, j + 1]) = (arr[i, j +1], arr[i, j]);
            }
            len--;
        }
    }
}

int rows = 3;
int columns = 4;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
Console.WriteLine("   ================");
Sort2dArray(array);
Display2dArray(array);
