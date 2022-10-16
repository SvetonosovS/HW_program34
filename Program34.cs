// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size;
Console.Write("Введите размер массива (N): ");
size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
Console.Write("[ ");
ArrayRandomNumbers(numbers);
Console.Write("]");

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}
Console.WriteLine($" -> {count} ");

void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + "; ");
    }
}