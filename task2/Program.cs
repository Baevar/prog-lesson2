int N, i;
Console.WriteLine("Введите число N");
N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
for (i = 0; i < N; i++)
{
    arr[i]=i+1;
    Console.Write("{0} ",arr[i]);
}
