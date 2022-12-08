// Напишите программу замена элементов массива:
// положительные элементы замените на отрицательные и наоборот.

// creates an array of nmemb pseudo-random integes in range[max, min]
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

// reverse values of array to positive or negative
void transMut_arr(int[] arr) {
    int len = arr.Length;
    for (int i = 0; i < len; i++) arr[i] = -arr[i];
}

int[] array = arr_of(12, -9, 9);
display_arr(array);
transMut_arr(array);
display_arr(array);
