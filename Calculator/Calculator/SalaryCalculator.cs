using System;

namespace Calculator
{
    class SalaryCalculator : ISalaryCalculator, ICalculator
    {
        private int _numberofdays = 0;
        private int _dailywages = 0;

        public SalaryCalculator(int NumberofDays = 0, int DailyWages = 0)
        {
            _numberofdays = NumberofDays;
            _dailywages = DailyWages;
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
        public double SalaryCalculate()
        {
            
            return (double) 0.0;
        }

        public double Calculate()
        {
            
        }
    }
}
