// Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию
// о том, сколько раз встречается элемент входных данных. Значения элементов
// массива 0 - 9

int MinRndmValue = 0;
int MaxRndmValue = 10;

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

void DisplayArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) Console.WriteLine($"{i} -> {arr[i]}");
}

// Determines the number of each element in the array.
int[] WordList(int[,] arr) {
    int[] list = new int[10];
    foreach (int item in arr) list[item] += 1;
    return list;

}
int rows = 3;
int columns = 4;

int[,] array = Array2d(rows, columns);
Display2dArray(array);
DisplayArray(WordList(array));