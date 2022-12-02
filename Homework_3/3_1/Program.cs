// Напишите программу которая принимает на вход пятизначное число
// и проверяет является ли оно палиндромом

// limits for five-digit numbers
int MIN_LIM = 10000;
int MAX_LIM = 99999;

int takeN() {
    int n = int.Parse(Console.ReadLine());
    while (n < MIN_LIM || n > MAX_LIM) {
        Console.WriteLine("Try again.");
        n = int.Parse(Console.ReadLine());
    }
    return n;
}

void siamese(int num) {
    string str = "Да";
    int i = MIN_LIM;
    Console.Write($"{num} -> ");
    while (i != 1) {
         if (num / i == num % 10) {
             num %= i;
             num /= 10;
             i /= 100;
        } else {
            str = "нет";
            break;
        }
    }
    Console.WriteLine(str);
}

Console.WriteLine("Please enter five-digit number>");
siamese(takeN());
