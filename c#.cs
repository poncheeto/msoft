string[] values = { "12.3", "45", "ABC", "11", "DEF"};

string message = "";
decimal total = 0.0m;

foreach (string value in values)
{
    decimal num;
    if(decimal.TryParse(value, out num))
    {
        total += num;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");