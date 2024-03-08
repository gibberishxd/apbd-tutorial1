// See https://aka.ms/new-console-template for more information


static double GetAvg(int[] numbers)
{
    double sum = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAvg(numbers);
Console.WriteLine(average);