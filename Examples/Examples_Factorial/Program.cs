double Factotial (int n)
{
    if (n == 1) return 1; // мы дошли до 1, то мы должны вернуть 1
    else return n * Factotial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factotial(i)}");
}


