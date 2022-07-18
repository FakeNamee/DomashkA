int size = 8;
Random random = new Random();
int[] array = new int[size];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-3, 4);
}
for (int i = 0; i < array.Length; i++)
{

    for (int j = 0; j < array.Length - 1; j++)
    {
        if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
        {
            max = array[j];
            array[j] = array[j + 1];
            array[j + 1] = max;

        }
    }
}
foreach (int num in array)
{
    Console.Write(num + " ");
}