Console.WriteLine("Введите A[x]");
int numberAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A[y]");
int numberAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите A[z]");
int numberAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B[x]");
int numberBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B[y]");
int numberBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B[z]");
int numberBz = Convert.ToInt32(Console.ReadLine());


double D = Math.Sqrt(Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy,2) + Math.Pow(numberAz - numberBz,2));
Console.WriteLine(Math.Round(D,2));

