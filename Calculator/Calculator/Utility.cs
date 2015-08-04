namespace Calculator
{
    class Utility
    {
        public bool IsNUmeric(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }
    }
}  
