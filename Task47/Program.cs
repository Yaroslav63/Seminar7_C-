double[,] a = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.Next(-10, 10) + random.NextDouble();
        Console.Write("{0,5:F1}\t", a[i, j]);
    }
    Console.WriteLine();
}