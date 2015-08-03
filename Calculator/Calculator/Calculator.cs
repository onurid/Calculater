using System;

namespace Calculator
{
    public class Calculator
    {
        private double _val1 = 0.0;
        private double _val2 = 0.0;
        private string _process = null;

        public Calculator()
        { }

        public string Val1
        {
            get { return _val1.ToString(); }
            set
            {
                IsNumeric(value, out _val1);
            }
        }
        public string Val2
        {
            get { return _val2.ToString(); }
            set
            {
                IsNumeric(value, out _val2);
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

        public bool IsNumeric(string value, out double val)
        {
            if (!string.IsNullOrEmpty(value))
            {
                try  // harf girilirse hata verecektir. 
                {
                    val = Convert.ToDouble(value);
                    return true;
                }
                catch
                {
                    val = 0;
                    return false;
                }
            }
            val = 0;
            return false;
        }
    }
}
