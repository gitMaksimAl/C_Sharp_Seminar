// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных
// элементов в промежутке от M до N с помощью рекурсии.

// Print to the console sum of all integers from
// small - m, to largest - n recursively.
void ForwardSumR(int m, int n, int sum) {
    if (m == n) Console.WriteLine(sum + n);
    else {
        sum += m + n;
        ForwardSumR(m + 1, n - 1, sum); 
    }
}

// Print to the console sum of all integers from
// largest - m, to smaller - n recursively.
void BackwardSumR(int m, int n, int sum) {
    if (m == n) Console.WriteLine(sum + n);
    else {
        sum += m + n;
        BackwardSumR(m - 1, n + 1, sum); 
    }
}

void PrintSumR(int m, int n, int sum) {
    if (m <= 0 || n <= 0) Console.WriteLine("Not possible.");
    else if (m > n) BackwardSumR(m, n, sum);
    else ForwardSumR(m, n, sum);
}

Console.WriteLine("Warning!!!!! Can be Stack overflow!!!");

int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

Console.Write(" -> ");
PrintSumR(M, N, 0);

