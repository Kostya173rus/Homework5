// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(double[] num)
{

    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        Console.Write(num[i] + " / ");
    }
    return num;
}



void CheckSum(double[] numbers)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
        {
            max = numbers[z];
        }
        if (numbers[z] < min)
        {
            min = numbers[z];
        }
    }

    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Console.Write("Массив: ");
GetArray(numbers);
CheckSum(numbers);