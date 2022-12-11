// Напишите программу, которая будет преобразовывать десятичное число в двоичное

string to_binary(int n) {
    string result = "";
    while (n > 0) {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine("Please eneter num>");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} to binary: {to_binary(num)}");
