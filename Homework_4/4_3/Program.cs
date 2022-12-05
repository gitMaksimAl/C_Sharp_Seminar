// Напишите программу которая задает массив из восьми элементов
// случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функций.

// creates an array of nmemb pseudo-random integers[0-9]
int[] arr_of(int nmemb) {
    int[] mass = new int[nmemb];
    for (int i = 0; i < nmemb; i++) mass[i] = new Random().Next(10);
    return mass;
}

// display values of the array
void display_arr(int[] arr) {
    int last = arr.Length - 1;
    int i = 0;
    Console.Clear();
    for (; i < last; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine(arr[i]);
}

display_arr(arr_of(8));
