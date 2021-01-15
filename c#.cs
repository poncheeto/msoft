string[] values = { "12.3", "45", "ABC", "11", "DEF"};

string message;
float sum = 0f;

foreach (string value in values)
{
    float num;
    if(float.TryParse(value, out num))
    {
      Console.WriteLine(num);
    }
}