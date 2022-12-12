// Пользователь вводит с клавиатуры M чисел.
// Посчитайте сколько чисел больше 0 ввел пользователь.

// read lines from console and counts the first num
// greater then zero, while line is not empty
int readNums() {
    string line = System.String.Empty;
    int num;
    int count = 0;
    line = Console.ReadLine();
    while (line != "") {
        if (line[0] > 48 && line[0] < 58) count++;
        line = Console.ReadLine();
    }
    return count;
}

Console.WriteLine($" -> {readNums()}");
