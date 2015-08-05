namespace Calculator
{
    public interface ICalculator
    {
        double FirstNumber { get; set; }
        double SecondNumber { get; set; }
        string Process { get; set; }

        void Calculator(string process, double firstNumber, double secondNumber);

        double Calculate();

        double Collect();
        double Interest();
        double Multiply();
        double Divide();
    }
}