// Напишите программу которая принимает на вход цифру обозначающую
// день недели и проверяет является ли этот день выходным

// function return Yes if the day is a holiday and No if not
string isWeekend(int day) {
    if (day > 0 && day < 6) return "Нет";
    else if (day > 0 && day < 8) return "Да";
    else return "В неделе 7 дней!!!";
}

Console.WriteLine("Please enter number of the day>");
Console.WriteLine(isWeekend(int.Parse(Console.ReadLine())));
