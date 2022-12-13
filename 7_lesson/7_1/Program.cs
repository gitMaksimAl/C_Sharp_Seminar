// Задайте двумерный массив рамера m*n, каждый элемент в массиве
// находится по формуле A[m, n] = m + n.
// Выведите полученный массив на экран.

// creates an rows*columns 2d array of pseudo-random integers in range[MinRndm, MaxRndm]
int[,] Get2dArray(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = i + j;
    }
    return mass;
}

// display values of the 2d array
void Display2dArray(int[,] arr) {
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        int j = 0;
        for (; j < columns - 1; j++) Console.Write($"{arr[i, j]}, ");
        Console.WriteLine(arr[i, j]);
    }
}

Display2dArray(Get2dArray(3, 4));
