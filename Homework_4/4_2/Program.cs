// Напишите программу которая принимает на вход число и
// выдает сумму цифр в числе.

int getSum(int n) {
    int sum = 0;
    Console.Clear();
    Console.Write($"{n} -> ");
    while (n > 0) {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

Console.WriteLine("Please eneter num>");
Console.WriteLine(getSum(int.Parse(Console.ReadLine())));
