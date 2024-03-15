int[] arr = { 24, 8, 12, 11, 7, 4, 16, 4, 2, 33 };
int i = 1, max = arr[0];
while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.WriteLine($"max(while)={max}");

max = arr[0];
for (int j = 1; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine($"max(for)={max}");
max = arr[0];

foreach (int k in arr)
{
    if (k > max)
    {
        max = k;
    }
}
Console.WriteLine($"max(foreach)={max}");