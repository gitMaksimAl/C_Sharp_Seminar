// Напишите программу, которая будет принимать на вход число и возвращать сумму
// его цифр используя на рекурсию.

int GetSumR(int num) {
    if (num == 0) return num;
    else return GetSumR(num / 10) + num % 10;
}

Console.WriteLine(GetSumR(int.Parse(Console.ReadLine())));
