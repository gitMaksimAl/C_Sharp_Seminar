// Напишите программу которая выводит массив из восьми элементов
// заполненый нулями и еденицами в случайном порядке

void print_massive(int n) {
    int[] arr = new int[n];
    for (int i = 0; i < n; i++) {
        arr[i] = new Random().Next(2);
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Enter nunber '8'>");
print_massive(int.Parse(Console.ReadLine()));
