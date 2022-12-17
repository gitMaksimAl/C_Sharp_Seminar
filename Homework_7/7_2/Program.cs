// Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что
// такого элемента нет.

// Creates an 2d array m * n of pseudo-doubles.
double[,] DoubleArray2d(int m, int n) {
    double[,] mass = new double[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) mass[i, j] = Math.Round(new Random(i).NextDouble() + j * (i + 1), 2);
    }
    return mass;
}

// Print value from arr with position positionI, positionJ if is exist.
void WriteValue(int positionI, int positionJ, double[,] arr) {
    int n = arr.GetLength(0);
    int m  = arr.GetLength(1);
    if ((positionI < 1 || positionI >= n) || (positionJ < 1 || positionJ >= m)) Console.WriteLine(" -> такого числа в массиве нет");
    else Console.WriteLine($" -> {arr[positionI - 1, positionJ - 1]}");
}

// Parse line from console.
int GetPosition() {
    string inputStirng = Console.ReadLine();
    if (inputStirng != null) return int.Parse(inputStirng);
    else return 0;
}

int ROWS = 3;
int COLUMNS = 4;

double[,] array = DoubleArray2d(ROWS, COLUMNS);
WriteValue(GetPosition(), GetPosition(), array);
