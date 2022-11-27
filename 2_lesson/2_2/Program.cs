// Напишите программу которая на вход будет принимать два числа и выводить
// является ли второе число кратным первому. Если второе число не кратно первому
// программа выводит остаток от деления.

void show_remainder(int divisor, int num) {
        if (num % divisor == 0) Console.WriteLine($"{num} is evenly divisible");
        else Console.WriteLine($"Remainder: {num % divisor}");
}

Console.WriteLine("Please enter two nums>");
show_remainder(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
