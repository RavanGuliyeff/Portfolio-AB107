int num = 397;

if (num > 1)
{
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("murekkeb");
            return;
        }
    }
}
else
{
    Console.WriteLine("ne sade, ne murekkeb");
    return;
}
Console.WriteLine("sade");

