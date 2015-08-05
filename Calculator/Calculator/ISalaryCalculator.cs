namespace Calculator
{
    public interface ISalaryCalculator
    {
        int NumberOfDays { get; set; }
        int DailyWages { get; set; }
        double Salary { get; set; }
        
        void SalaryCalculate();
    }
}