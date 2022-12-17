// Задайте двумерный массив. Введите элемент и найдите его первое вхождение,
// выведите позиции по горизонтали и вертикали, или напишите что такого элемента нет.

int MinRndm = 1;
int MaxRndm = 12;

// creates an rows*columns 2d array of pseudo-random integers in range[MinRndm, MaxRndm]
int[,] Get2dArray(int rows, int columns) {
    int[,] mass = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++)
            mass[i, j] = new Random().Next(MinRndm, MaxRndm);
    }
    return mass;
}

// display values of the 2d array
void Display2dArray(int[,] arr) {
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++) {
        int j = 0;
        for (; j < columns - 1; j++) Console.Write($"{arr[i, j], -3}, ");
        Console.WriteLine(arr[i, j]);
    }
}

string GetPosition(int find, int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) if (arr[i, j] == find) return $" -> [{i}, {j}]";
    }
    return $" -> Not found";
}

int[,] array = Get2dArray(6, 6);
Display2dArray(array);
Console.WriteLine("What num you search");
Console.WriteLine(GetPosition(int.Parse(Console.ReadLine()), array));
