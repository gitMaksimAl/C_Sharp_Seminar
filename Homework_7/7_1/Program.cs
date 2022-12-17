// Задайте двумерный массив m * n, заполненый случайными вещественными числами.

// Creates an 2d array m * n of pseudo-doubles.
double[,] DoubleArray2d(int m, int n) {
    double[,] mass = new double[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) mass[i, j] = Math.Round(new Random(i).NextDouble() + j * (i + 1), 2);
    }
    return mass;
}

// Display values of the 2d array.
void Display2Dimensional(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j], 6} ");
        Console.Write('\n');
    }
}

// Parse line from console.
int MembersAmount(string messg) {
    Console.Write(messg);
    string inputStirng = Console.ReadLine();
    if (inputStirng != null) return int.Parse(inputStirng);
    else return 0;
}

int rows = 0;
int columns = 0;

rows = MembersAmount("m = ");
columns = MembersAmount("n = ");
double[,] array = DoubleArray2d(rows, columns);
Display2Dimensional(array);
