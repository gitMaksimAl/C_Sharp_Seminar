// Не используя рекурсию, выведите первые N чисел Фибоначчи

void Fibonacci(int n) {
    int a = 0;
    int b = 1;
    for (int i = 0; i < n - 1; i++) {
        Console.Write($"{a}, ");
        (a, b) = (b, a + b);
    }
    Console.WriteLine(a);
}

Console.WriteLine("Please enter num>");
Fibonacci(int.Parse(Console.ReadLine()));
