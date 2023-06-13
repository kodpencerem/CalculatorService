using System;
using System.ServiceModel;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)] // app.config üzerinde açık
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CalculatorService : ICalculatorService
    {
        public float Divide(float Numerator, float Denominator)
        {
            if (Denominator == 0)
            {
                throw new FaultException("Denominator Can't Be Zero", new FaultCode("DivideByZeroFault"));
            }
            return Numerator / Denominator;
        }
    }
}