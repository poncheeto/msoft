string[] values = { "12.3", "45", "ABC", "11", "DEF"};

string message;
float num = 0f;

foreach (string value in values)
{
    if(float.TryParse(value, out num))
    {
      Console.WriteLine(num);
    }
}