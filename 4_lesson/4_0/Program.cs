// Напишите программу которая принимает на вход число N и выдает сумму чисел от 1 до N

int sumNums(int n) {
    int sum = 0; // переменная аккумулятор
    for (int i = 1; i <= n; i++) sum += i;
    return sum;
}

Console.WriteLine(sumNums(int.Parse(Console.ReadLine())));
