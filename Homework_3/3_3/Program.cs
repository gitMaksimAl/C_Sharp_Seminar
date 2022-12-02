// Напишите программу которая принимает на вход число N и выдает таблицу кубов
// чисел от 1 до N

int positiveN() {
    int num = int.Parse(Console.ReadLine());
    while (num <= 0) {
        Console.WriteLine("Need positive number");
        num = int.Parse(Console.ReadLine());
    }
    return num;
}
void cubes(int n) {
    Console.Clear();
    Console.Write($"{n} -> ");
    int i = 1;
    while (i < n) {
        Console.Write($"{i * i * i}, ");
        i++;
    }
    Console.WriteLine(i * i * i);
}

Console.WriteLine("Please enter num>");
cubes(positiveN());
