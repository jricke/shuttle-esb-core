using System;
using System.Collections.Generic;
using System.IO;

namespace Shuttle.ESB.Core
{
	public interface IMessageSender
    {
        TransportMessage CreateTransportMessage(object message, Action<TransportMessageConfigurator> configure);
        TransportMessage CreateTransportMessage(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure);

		void Dispatch(TransportMessage transportMessage);
        TransportMessage Send(object message);
        TransportMessage Send(string messageType, Stream serializedMessage);
        TransportMessage Send(object message, Action<TransportMessageConfigurator> configure);
        TransportMessage Send(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure);
        IEnumerable<TransportMessage> Publish(object message);
        IEnumerable<TransportMessage> Publish(string messageType, Stream serializedMessage);
        IEnumerable<TransportMessage> Publish(object message, Action<TransportMessageConfigurator> configure);
        IEnumerable<TransportMessage> Publish(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure);
	}
}