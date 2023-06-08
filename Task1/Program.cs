// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);

        Console.Write(arr[i] + " ");
    }
    return arr;
}

void Countmassiv(int[] numbers)
{


    int count = 0;

    for (int a = 0; a < numbers.Length; a++)
    {
        if (numbers[a] % 2 == 0)
            count++;
    }
    if (count > 0)
        Console.WriteLine($"-> только {count} четных числа");
    else Console.WriteLine($"-> только нечетные числа");

}
Console.Write("В массиве: ");
int[] array = GetArray(4, 100, 999);
Countmassiv(array);