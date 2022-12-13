// Напишите программу которая будет создавать копию заданного массива с помощью поэлементного копирования

int MIN_RNDM = -9;
int MAX_RNDM = 9;

// creates an rows*columns 2d array of pseudo-random integers in range[MIN_RNDM, MAX_RNDM]
int[,] arr2d_of(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MIN_RNDM, MAX_RNDM);
    }
    return mass;
}

// display values of the 2d array
void display_arr2d(int[,] arr) {
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        int j = 0;
        for (; j < columns - 1; j++) Console.Write($"{arr[i, j]}, ");
        Console.WriteLine(arr[i, j]);
    }
}

// clone values of 2d array, from src to dest
void get_arr2d_clone(int[,] dest, int[,] src) {
    int rows = src.GetLength(0);
    int columns = src.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) dest[i, j] = src[i, j];
    }
}

int[,] array1 = arr2d_of(3, 5);
display_arr2d(array1);
Console.WriteLine("=================");
int[,] array2 = new int[array1.GetLength(0), array1.GetLength(1)];
get_arr2d_clone(array2, array1);
display_arr2d(array2);
