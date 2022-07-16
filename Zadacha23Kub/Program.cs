Random random = new Random();
int number = random.Next (1, 11);
Console.WriteLine ("Число: " + number);

for (int i=1; i<=number; i++)
{
    Console.WriteLine (i + " в кубе= " + Math.Pow (i, 3));
}
