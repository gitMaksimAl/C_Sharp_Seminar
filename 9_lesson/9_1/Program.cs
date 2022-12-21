// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все
// натуральные числа от M до N.

void PrintRangeR(int m, int n) {
    if (n == m) Console.Write($"{m} ");
    else {
        PrintRangeR(m, n - 1);
        Console.Write($"{n} ");
    }
}

PrintRangeR(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
