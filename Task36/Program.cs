// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите желаемую длину массива");
int size = Convert.ToInt32(Console.ReadLine());

int minValue = -99;
int maxValue = 99;

int[] numbers = new int[size];
numbers = FillArrayRandom(numbers, minValue, maxValue);

int sum = 0;

for(int i = 1; i < numbers.Length; i += 2)
{
    sum += numbers[i];
}

Console.Write("["+String.Join(", ", numbers)+ "] -> "+ sum);
Console.WriteLine();

int[] FillArrayRandom(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

