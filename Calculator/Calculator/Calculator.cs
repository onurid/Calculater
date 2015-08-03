using System;

namespace Calculator
{
    public static class Calculator
    {
        private static double _val1 = 0.0;
        private static double _val2 = 0.0;
        private static string _process = null;

        public static string Val1
        {
            get { return _val1.ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _val1 = Convert.ToDouble(value);
            }
        }
        public static string Val2
        {
            get { return _val2.ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _val2 = Convert.ToDouble(value);
            }
        }
        public static string Process
        {
            get { return _process; }
            set { _process = value; }
        }

        public static double Calculate()
        {
            switch (Process)
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

        private static double Collect()
        {
            return _val1 + _val2;
        }
        private static double Interest()
        {
            return _val1 - _val2;
        }
        private static double Multiply()
        {
            return _val1 * _val2;
        }
        private static double Divide()
        {
            return _val1 / _val2;
        }
    }
}
