// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент
// массива.

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

// Searches for the index of the minimum value in an array.
int[] IndexofSmallest(int[,] arr) {
    int[] index = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if (arr[index[0], index[1]] > arr[i, j]) {
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

// Print cuted 2d arr by index(es) to the console.
void DisplayCutedArr(int[,] arr, int[] index) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if (i == index[0] || j == index[1]) continue;
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.Write('\n');
    }
}

int rows = 5;
int columns = 6;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
Console.WriteLine("==============");
DisplayCutedArr(array, IndexofSmallest(array));
