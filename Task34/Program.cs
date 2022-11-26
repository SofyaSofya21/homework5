// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите желаемую длину массива");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = 100;
int maxValue = 999;

int[] numbers = new int[size];
numbers = FillArrayRandom(numbers, minValue, maxValue);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]%2 == 0)
        count++;
}

Console.Write("["+String.Join(", ", numbers)+ "] -> "+ count);
Console.WriteLine();


int[] FillArrayRandom(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


