// Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.

// creates an array of nmemb pseudo-random integers in range[max, min]
int[] arr_of(int nmemb, int min, int max) {
    int[] mass = new int[nmemb];
    for (int i = 0; i < nmemb; i++) mass[i] = new Random().Next(min, max);
    return mass;
}

// display values of the array
void display_arr(int[] arr) {
    int last = arr.Length - 1;
    int i = 0;
    //Console.Clear();
    for (; i < last; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine(arr[i]);
}

// return 'yes' if num in array and 'no' if not
string inArray(int num, int[] arr) {
    string ret = "No";
    int len = arr.Length;
    for (int i = 0; i < len; i++) {
        if (arr[i] == num) {
            ret = "Yes";
            break;
        }
    }
    return ret;
}

int[] array = arr_of(12, -9, 9);
display_arr(array);
Console.WriteLine("Which num do you want to find in the array>");
Console.WriteLine(inArray(int.Parse(Console.ReadLine()), array));
