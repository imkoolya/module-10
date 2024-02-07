interface ICalculator
{
    int Add(int a, int b);
}
class BasicCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            ICalculator calculator = new BasicCalculator();
            int result = calculator.Add(a, b);

            Console.WriteLine("Результат сложения: {0}", result);
        }
        catch
        {
            Console.WriteLine("Ошибка: Неверный формат.");
        }
        finally
        {
            Console.WriteLine("Работа калькулятора завершена.");
        }
    }
}