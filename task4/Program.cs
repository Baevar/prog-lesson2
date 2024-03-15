int[] arr = { 24, 8, 12, 11, 7, 4, 16, 4, 2, 33 };
int i = 1, max = arr[0];
while (i <arr.Length)
{
    if (arr[i]>max)
    {
        max= arr[i];
    }
    i++;
}
Console.WriteLine($"max={max}");
