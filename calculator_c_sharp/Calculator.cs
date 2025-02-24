namespace calculator_c_sharp
{
    public class Calculator : ICalculator
    {
        public double AddNumbers(double a, double b) => a + b;
        public double SubtractNumbers(double a, double b) => a - b;
        public double MultiplyNumbers(double a, double b) => a * b;
        public double DivideNumbers(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Feil: Kan ikke dele på null!");
            return a / b;
        }
    }
}
