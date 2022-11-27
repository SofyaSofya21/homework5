// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Введите желаемую длину массива");
int size = Convert.ToInt32(Console.ReadLine());

double minValue = -99;
double maxValue = 99;

double[] numbers = new double[size];
numbers = FillArrayRandom(numbers, minValue, maxValue);

double max = 0;
double min = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>max)
        max = numbers[i];
    else if (numbers[i]<min)
        min = numbers[i];
}

double sum = max - min;

Console.WriteLine("["+String.Join(", ", numbers)+ "] -> "+ sum);


double[] FillArrayRandom(double[] array, double min, double max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(max-min)+min, 2);
    }
    return array;
}

