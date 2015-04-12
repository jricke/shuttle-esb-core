using System;
using System.Collections.Generic;
using System.IO;
using Shuttle.Core.Infrastructure;

namespace Shuttle.ESB.Core
{
	public class HandlerContext<T> : IMessageSender
		where T : class
	{
		private readonly IServiceBus _bus;
		private readonly IMessageSender _messageSender;

		public HandlerContext(IServiceBus bus, TransportMessage transportMessage, T message, IThreadState activeState)
		{
			Guard.AgainstNull(bus, "bus");
			Guard.AgainstNull(transportMessage, "transportMessage");
			Guard.AgainstNull(message, "message");
			Guard.AgainstNull(activeState, "activeState");

			_bus = bus;
			_messageSender = new MessageSender(bus, transportMessage);

			TransportMessage = transportMessage;
			Message = message;
			ActiveState = activeState;
			Configuration = _bus.Configuration;
		}

		public TransportMessage TransportMessage { get; private set; }
		public T Message { get; private set; }
		public IThreadState ActiveState { get; private set; }
		public IServiceBusConfiguration Configuration { get; private set; }

		public TransportMessage CreateTransportMessage(object message, Action<TransportMessageConfigurator> configure)
		{
			return _messageSender.CreateTransportMessage(message, configure);
		}

	    public TransportMessage CreateTransportMessage(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure)
        {
            return _messageSender.CreateTransportMessage(messageType, serializedMessage, configure);
	    }

	    public void Dispatch(TransportMessage transportMessage)
		{
			_messageSender.Dispatch(transportMessage);
		}

        public TransportMessage Send(object message)
        {
            return _messageSender.Send(message);
        }

        public TransportMessage Send(string messageType, Stream serializedMessage)
        {
            return _messageSender.Send(messageType, serializedMessage);
        }

		public TransportMessage Send(object message, Action<TransportMessageConfigurator> configure)
		{
			return _messageSender.Send(message, configure);
		}

        public TransportMessage Send(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure)
        {
            return _messageSender.Send(messageType, serializedMessage, configure);
        }

        public IEnumerable<TransportMessage> Publish(object message)
        {
            return _messageSender.Publish(message);
        }

        public IEnumerable<TransportMessage> Publish(object message, Action<TransportMessageConfigurator> configure)
        {
            return _messageSender.Publish(message, configure);
        }

        public IEnumerable<TransportMessage> Publish(string messageType, Stream serializedMessage)
        {
            return _messageSender.Publish(messageType, serializedMessage);
        }

        public IEnumerable<TransportMessage> Publish(string messageType, Stream serializedMessage, Action<TransportMessageConfigurator> configure)
        {
            return _messageSender.Publish(messageType, serializedMessage, configure);
        }
	}
}
