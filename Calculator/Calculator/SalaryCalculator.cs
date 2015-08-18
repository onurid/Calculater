using System;

namespace Calculator
{
    class SalaryCalculator : ISalaryCalculator
    {
        private int _numberofdays = 0;
        private int _dailywages = 0;
        private double _salary = 0.0;

        public SalaryCalculator(int numberofDays = 0, int dailyWages = 0)
        {
            _numberofdays = numberofDays;
            _dailywages = dailyWages;
        }

        public int NumberOfDays
        {
            get { return _numberofdays; }
            set { _numberofdays = value; }
        }
        public int DailyWages
        {
            get { return _dailywages; }
            set { _dailywages = value; }
        }
        public double Salary
        {
            get { return (int) _salary; }
            set { _salary = value; }
        }
        public void SalaryCalculate()
        {
            //FirstNumber = NumberOfDays;
            //SecondNumber = DailyWages;
            //Process = "*";
            //Calculate();
            //Salary = Result;
        }
    }
}
