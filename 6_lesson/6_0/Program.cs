// Напишите программу, которая перевернет одномерный массив.

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

void rev_mass(int[] arr) {
    int len = arr.Length;
    for (int i = 0; i < len / 2; i++) (arr[i], arr[len - 1 - i]) = (arr[len - 1 - i], arr[i]); // use tuple
}

int[] array = arr_of(8, -9, 9);
display_arr(array);
rev_mass(array);
display_arr(array);
