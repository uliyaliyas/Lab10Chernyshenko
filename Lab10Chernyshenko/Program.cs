class Program
{
    static void Main()
    {
        try
        {
            Drob drob = new Drob();
            double Procent = drob.Procent();
            Console.WriteLine("Значение дроби в процентах: " + Procent);
            int Summa = drob.Sum();
            Console.WriteLine($"Сумма цифр знаменателя: " + Summa);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка ввода: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
class Drob
{
    private int numerator;
    private int denominator;
    public Drob()
    {
        Console.WriteLine("Введите числитель");
        numerator = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите знаменатель");
        denominator = int.Parse(Console.ReadLine()!);
    }
    public double Procent()
    {
        return (double)numerator / denominator * 100;
    }
    public int Sum()
    {
        int sum = 0;
        int tempDenominator = denominator;

        while (tempDenominator != 0)
        {
            sum += tempDenominator % 10;
            tempDenominator /= 10;
        }

        return sum;
    }
}

class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public virtual double ToDecimal()
    {
        return (double)Numerator / Denominator;
    }
}
class MixedFraction : Fraction
{
    public int WholePart { get; set; }

    public MixedFraction(int wholePart, int numerator, int denominator) : base(numerator, denominator)
    {
        WholePart = wholePart;
    }
    public override double ToDecimal()
    {
        return WholePart + base.ToDecimal();
    }
}