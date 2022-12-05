// Напишите программу которая принимает на вход число и выдает количество цифр в числе.

int Counter(int n) {
    Console.WriteLine("WARNING!!! function work with not more ten-digit nums.");
    int count = 0;
    if (n == 0) count = 1;
    else while (n > 0) {
        count++;
        n /= 10;
    }
    return count;
}

Console.WriteLine(Counter(int.Parse(Console.ReadLine())));
