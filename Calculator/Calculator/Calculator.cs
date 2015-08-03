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
                _val1 = IsNumeric(value);
            }
        }
        public string Val2
        {
            get { return _val2.ToString(); }
            set
            {
                _val2 = IsNumeric(value);
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

        public double IsNumeric(string value)
        {
            if (string.IsNullOrEmpty(value)) return (double)0.0;

            double number;
            if (double.TryParse(value, out number))
                return number;
            
            return (double) 0.0;
        }
    }
}
