// Напишите программу которая принимает на вход число N и выдает таблицу квадратов чисел
// от 1 до N

void Pow_to(int n) {
    int i = 1;
    while (i <= n) {
        Console.Write($"{i * i}, ");
        i++;
    }
}

Console.WriteLine("Enter positive num>");
Pow_to(int.Parse(Console.ReadLine()));
