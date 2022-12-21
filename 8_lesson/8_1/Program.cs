// Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае если это не возможно, программа должна вывести сообщение
// для пользователя.

int MinRndmValue = -9;
int MaxRndmValue = 9;

// Creates an rows*columns 2d array of pseudo-random integers in range
// [MinRndmValue, MaxRndmValue].
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

// Transposition of 2d quad array.
void Transposition2d(int[,] arr) {
    if (arr.GetLength(0) == arr.GetLength(1)) {
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < i; j++)
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
        }
    }
}

int rows = 3;
int columns = 3;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
Console.WriteLine("==============");
Transposition2d(array);
Display2dArray(array);
