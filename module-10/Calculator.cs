public class Calculator : ICalculator
{
    ILogger Logger { get; }
    public Calculator(ILogger logger)
    {
        Logger = logger;
    }
    public int Add(int a, int b)
    {
        Logger.Event("The calculator is started.");
        return a + b;
    }
}