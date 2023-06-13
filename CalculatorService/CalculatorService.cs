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
            try
            {
                return Numerator / Denominator;
            }
            catch (DivideByZeroException ex)
            {
                DivideByZeroFault fault = new DivideByZeroFault();
                fault.Error = ex.Message;
                fault.Details = "Denominator Can't Be Zero";

                throw new FaultException<DivideByZeroFault>(fault);
            }          
        }
    }
}