public interface ICalculator
{
    int Add(int a, int b);
}
public interface ILogger
{
    void Event(string message);
    void Error(string message);
}
public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
    }
    public void Error(string message)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }
}
class Program
{
    static ILogger Logger { get; set; }
    static void Main(string[] args)
    {
        Logger = new Logger();
        var calculator = new Calculator(Logger);
        try
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = calculator.Add(a, b);

            Console.WriteLine("Result: {0}", result);
        }
        catch
        {
            throw new FormatException();
        }
        finally
        {
            Console.WriteLine("The calculator is finished.");
        }
    }
}