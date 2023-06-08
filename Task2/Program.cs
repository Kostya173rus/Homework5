// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void CheckSum(int[] numbers)
{
    int sum = 0;
  for (int y = 0; y < numbers.Length; y+=2) // если бы y=1 то считались бы четные индексы массива
    sum = sum + numbers[y];

    Console.WriteLine($"Сумма элементов cтоящих на нечётных позициях = {sum}");

}
Console.Write("Массив: ");
int[] array = GetArray(4, 1, 25);
Console.WriteLine("");
CheckSum(array);