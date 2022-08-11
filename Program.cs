Console.WriteLine("Введите количество элиментов массива");
int N = Convert.ToInt32(Console.ReadLine());
int i;
Console.WriteLine("Mассив:");
string[] array = new string[N];

for (i = 0; i < N; i++)
{
    Console.WriteLine($"Введите элимент массива с индексом {i}");
    array[i] = Console.ReadLine();
}

Console.Write("Mассив: [");
for (i = 0; i < N; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");

int count = 0;
for (i = 0; i < N; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
Console.WriteLine();

string[] array2 = new string[count];

int j = 0;
Console.Write("Новый массив: [");
for (i = 0; i < N; i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        Console.Write(array2[j] + " ");
        j++;
    }

}
Console.Write("]");
Console.WriteLine();









