// double Factotial (int n)
// {
//     if (n == 1) return 1; // мы дошли до 1, то мы должны вернуть 1
//     else return n * Factotial(n - 1);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factotial(i)}");
// }


string res = String.Empty;
for (int i = 0; i < 10; i++)
{
    int id = i +1;
    string smena = $"{new Random().Next(1,13)}";
    string Name = $"Смирнова_Валентина_Егоровна_{id}";
    string tel = $"+7918{new Random().Next(100_00_00, 999_99_99)}";
    string repo = $"{smena}\n";
    res+=repo;

}

File.WriteAllText("db.csv", res);
//  System.Console.WriteLine(res);