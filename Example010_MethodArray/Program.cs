int[] array = { 10, 12, 32, 4, 25, 16, 71, 4 };

int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}