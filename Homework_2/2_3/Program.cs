// Напишите программу которая выводит третью цифру заданного
// числа или сообщает что третьей цифры нет

// function return third digit of the number
int getThird(int n) {
    if (n < 100) {
        Console.WriteLine("Третьей цифры нет!!!");
        return 0;
    } else {
        while (n > 999) n /= 10;
        return n % 10;
    }
}

Console.WriteLine("Please enter three-digit number>");
Console.WriteLine(getThird(int.Parse(Console.ReadLine())));
