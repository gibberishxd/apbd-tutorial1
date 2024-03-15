// See https://aka.ms/new-console-template for more information


static double GetAvg(int[] numbers)
{
    double different_name_lol = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        different_name_lol += numbers[i];
    }

    return different_name_lol / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAvg(numbers);
Console.WriteLine(average);