using System;

namespace Calculator
{
    public class Calculator
    {
        private double _val1 = 0.0;
        private double _val2 = 0.0;
        private string _process = null;

        public string Val1
        {
            get { return _val1.ToString(); }
            set
            {
                if (IsNumeric(value))
                    _val1 = Convert.ToDouble(value);
            }
        }
        public string Val2
        {
            get { return _val2.ToString(); }
            set
            {
                if (IsNumeric(value))
                    _val2 = Convert.ToDouble(value);
            }
        }
        public string Process
        {
            get { return _process; }
            set { _process = value; }
        }

        public double Calculate()
        {
            switch (_process)
            {
                case "+":
                    return Collect();
                    
                case "-":
                    return Interest();

                case "*":
                    return Multiply();

                case "/":
                    return Divide();

                default:
                    return (double) 0.0;
            }
        }

        private double Collect()
        {
            return _val1 + _val2;
        }
        private double Interest()
        {
            return _val1 - _val2;
        }
        private double Multiply()
        {
            return _val1 * _val2;
        }
        private double Divide()
        {
            return _val1 / _val2;
        }

        public bool IsNumeric(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }
    }
}
