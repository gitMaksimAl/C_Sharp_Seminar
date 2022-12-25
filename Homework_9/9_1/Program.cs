// Задайте значения M и N. Напишите программу, которая выведет все четные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// Print to the console all even nums from
// small - m, to largest - n recursively.
void ForwardEvensR(int m, int n) {
    if (m == n) Console.WriteLine("");
    else if (m > 0 && m % 2 == 0) {
        Console.Write($"{m} ");
        ForwardEvensR(m + 1, n);
    } else ForwardEvensR(m + 1, n); 
}

// Print to the console all even nums from
// largest - m, to smaller - n recursively.
void BackwardEvensR(int m, int n) {
    if (m == n) Console.WriteLine("");
    else if (m > 0 && m % 2 == 0) {
        Console.Write($"{m} ");
        BackwardEvensR(m - 1, n);
    } else BackwardEvensR(m - 1, n); 
}

void PrintEvenR(int m, int n) {
    if (m > n) BackwardEvensR(m, n);
    else ForwardEvensR(m, n);
}

int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

Console.Write(" -> ");
PrintEvenR(M, N);
