// Zadanie 5
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
        int minVal = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minVal])
            {
                minVal = j;
            }
        }

        int tmp = array[minVal];
        array[minVal] = array[i];
        array[i] = tmp;
    }
}

Console.WriteLine("Wygenerowana tablica");
GenerateRandomArray(size);
PrintArray(tab);
Console.WriteLine("Posortowana tablica");
Sort(tab);
PrintArray(tab);