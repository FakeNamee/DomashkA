Console.WriteLine("Введите два любых числа : ");
Console.Write("a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int numberB = Convert.ToInt32(Console.ReadLine());

    if(numberA > numberB)
    {
        Console.WriteLine("a > b");
    }
    else
    {
        Console.WriteLine("a < b");
    }