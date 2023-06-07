namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)] // app.config üzerinde açık
    public class CalculatorService : ICalculatorService
    {
        public float Divide(float Numerator, float Denominator)
        {
            return Numerator/Denominator;
        }
    }
}