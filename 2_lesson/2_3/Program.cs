// Напишите программу которая принимает на вход число и проверяет кратно ли оно
// одновременно 7 и 23

string Seven_and_23(int num) {
        if (num % 7 == 0 && num % 23 == 0) return "Yes!!!";
        else return "No.";
}

Console.WriteLine("Please enter then num>");
Console.WriteLine(Seven_and_23(int.Parse(Console.ReadLine())));
