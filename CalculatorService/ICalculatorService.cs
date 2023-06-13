using System.ServiceModel;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [FaultContract(typeof(DivideByZeroFault))]
        [OperationContract]
        float Divide(float Numerator, float Denominator);
    }
}
