namespace Calculator
{
    public interface ISalaryCalculator
    {
        int NumberOfDays { get; set; }
        int DailyWages { get; set; }
        double SalaryCalculate();
    }
}