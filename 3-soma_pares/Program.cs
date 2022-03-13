int x = int.Parse(Console.ReadLine());
int m = 0;
while (x > 0)
{
    m = 0;
    if (x % 2 == 0)
    {
        for (int i = 0; i < 10; i += 2)
        {
            m += x + i;
        }
    }
    else
    {
        x += 1;
        for (int i = 0; i < 10; i += 2)
        {
            m += x + i;
        }
    }
    Console.WriteLine($"{m}");
    x = int.Parse(Console.ReadLine());
}
