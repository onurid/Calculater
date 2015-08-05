namespace Calculator
{
    public interface ICalculator
    {
        double FirstNumber { get; set; }
        double SecondNumber { get; set; }
        string Process { get; set; }

        double Calculate();
    }
}