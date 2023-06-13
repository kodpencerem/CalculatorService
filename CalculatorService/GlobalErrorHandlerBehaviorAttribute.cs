using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace CalculatorService
{
    public class GlobalErrorHandlerBehaviorAttribute : Attribute, IServiceBehavior
    {
        private readonly Type _errorHandlerType;
        public GlobalErrorHandlerBehaviorAttribute(Type errorHandlerType) 
        {
            _errorHandlerType = errorHandlerType;
        }
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            
        }
        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            throw new NotImplementedException();
        }
        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            IErrorHandler errorHandler = (IErrorHandler)Activator.CreateInstance(this._errorHandlerType);
            foreach (ChannelDispatcher channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher channelDispatcher = channelDispatcherBase as ChannelDispatcher;
                if (channelDispatcher != null)
                {
                    channelDispatcher.ErrorHandlers.Add(errorHandler);
                }
            }
        }


    }
}
