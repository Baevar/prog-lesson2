int N, i;
Console.WriteLine("Введите число N");
N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N + 1];
for (i = 0; i < arr.Length; i++)
{
    arr[i] = i;
    if (arr[i] % 2 == 0)
        Console.Write("{0} ", arr[i]);
}
