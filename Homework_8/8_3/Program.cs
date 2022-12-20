// Задайте две матрицы. Напишите программу, которая будет находить произведение
// двух матриц.

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

// Returns a matrix C - the result of multiplying matrices A and B
int[,] GetSum2dMatrix(int[,] A, int[,] B) {
    int row = A.GetLength(0);
    int column = B.GetLength(1);
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    if (A.GetLength(1) != B.GetLength(0)) {
        Console.WriteLine("Not possible.");
        return C;
    }
    for (int i = 0; i < row; i++) {
        for (int j = 0, sum = 0; j < column; j++, sum = 0) {
            for (int k = 0; k < A.GetLength(1); k++) sum += A[i, k] * B[k, j];
            C[i, j] = sum;
        }    
    }
    return C;
}

int GetArraySize(string message) {
    Console.Write(message);
    string input = Console.ReadLine();
    if (input != null) return int.Parse(input);
    else return 0;
}

int[,] matrixA = Array2d(GetArraySize("rows = "), GetArraySize("columns = "));
int[,] matrixB = Array2d(GetArraySize("rows = "), GetArraySize("columns = "));
int[,] matrixC = GetSum2dMatrix(matrixA, matrixB);
Display2dArray(matrixA);
Console.WriteLine("\n\t*\n");
Display2dArray(matrixB);
Console.WriteLine("\n\t||\n\t\\/\n");
Display2dArray(matrixC);