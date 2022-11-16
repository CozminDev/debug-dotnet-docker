// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while (true)
{
    Thread.Sleep(5000);
    Console.WriteLine($"Time is {DateTime.UtcNow}");
}
