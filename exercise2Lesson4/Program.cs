void multiplicity(int a)
{
     if(a % 2 == 0)
     Console.WriteLine(a);
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= number)
    {
    multiplicity(i);
    i++;
    }

