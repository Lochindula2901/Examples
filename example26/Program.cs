int N = 8;
int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

Console.WriteLine('[' + string.Join(", ", SetArray(N)) + ']');

