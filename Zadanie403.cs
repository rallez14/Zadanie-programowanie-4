// Zadanie 3
const int size = 50;
int[] tab = new int[size];

void GenerateRandomArray(int size) 
{
    Random random = new Random((int)DateTime.Now.Ticks);
    for (int i = 0; i < size; i++)
    {
        tab[i] = random.Next(0, 11);
    }
}

void PrintArray(int[] myArray)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"[{i}] {myArray[i]}");
    }
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
}

Console.WriteLine("Wygenerowana tablica");
GenerateRandomArray(size);
PrintArray(tab);
Console.WriteLine("Posortowana tablica");
Sort(tab);
PrintArray(tab);