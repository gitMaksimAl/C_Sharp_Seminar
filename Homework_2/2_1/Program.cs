// Напишите программу которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру

// function wait three-digit number from console
int getThreeDig() {
        int x = int.Parse(Console.ReadLine());
        while (x < 100 || x > 999) {
            Console.WriteLine("Try again.");
            x = int.Parse(Console.ReadLine());
        }
        return x;
}

// function parse the three-digit number and output a second
void printSecond(int n) {
    n = n / 10;
    Console.WriteLine(n % 10);
}

Console.WriteLine("Please enter three-digit number>");
printSecond(getThreeDig());
