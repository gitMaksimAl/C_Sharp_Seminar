// Напишите программу которая принимает на вход трехзначное число и на выходе показывает
// последнюю цифру
int getLast(int num) {
    Console.WriteLine(num);
    return num % 10;
}
Console.WriteLine(getLast(new Random().Next(100, 1000)));
