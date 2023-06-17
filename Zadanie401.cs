// Zadanie 1
int size, min, max;

Console.Write("Podaj rozmiar tablicy: ");
size = Convert.ToInt32(Console.ReadLine());

Console.Write("Minimalna wartość tablicy: ");
min = Convert.ToInt32(Console.ReadLine());

Console.Write("Maksymalna wartość tablicy: ");
max = Convert.ToInt32(Console.ReadLine());

int[] tab = new int[size];

void GenerateRandomArray(int size)
{
    Random random = new Random((int)DateTime.Now.Ticks);
    for (int i = 0; i < size; i++)
    {
        tab[i] = random.Next(min, max + 1);
    }
}

void PrintArray(int[] myArray)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"[{i}] {myArray[i]}");
    }
}

void ReverseArray(int[] myArray)
{
    int tmp;
    for (int i = 0; i < size / 2; i++)
    {
        tmp = myArray[i];
        myArray[i] = myArray[size - 1 - i];
        myArray[size - 1 - i] = tmp;
    }
}

Console.WriteLine("Wygenerowana tablica");
GenerateRandomArray(size);
PrintArray(tab);
Console.WriteLine();
Console.WriteLine("Odwrócona tablica");
ReverseArray(tab);
PrintArray(tab);