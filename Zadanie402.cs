// Zadanie 2
int[] tab = {0, 11, 22, 33, 44, 55, 66, 77, 88, 99, -1, 122};

int MaxValue(int[] array)
{
    int maxValue = array[0];
    foreach (var number in array)
    {
        if (number > maxValue)
        {
            maxValue = number;
        }
    }

    return maxValue;
}

int MinValue(int[] array) 
{
    int minValue = array[0];
    foreach (var number in array)
    {
        if (number < number)
        {
            minValue = number;
        }
    }

    return minValue;
}

Console.WriteLine($"Max = {MaxValue(tab)}");
Console.WriteLine($"Min = {MinValue(tab)}");