namespace Calculator
{
    class Utility : IUtility
    {
        public bool IsNUmeric(string value)
        {
            double number;
            return double.TryParse(value, out number);
        }
    }
}  
