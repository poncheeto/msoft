string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
  Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement,
// it can be accessed later in your code.
if (result > 0)
  Console.WriteLine($"Measurement (w/ offset): {50 + result}");