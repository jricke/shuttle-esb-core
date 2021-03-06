﻿using System;
using Shuttle.Core.Infrastructure;

namespace Shuttle.ESB.Core
{
	public class DispatchTransportMessagePipeline : MessagePipeline
	{
		public DispatchTransportMessagePipeline(IServiceBus bus)
			: base(bus)
		{
			RegisterStage("Send")
				.WithEvent<OnFindRouteForMessage>()
				.WithEvent<OnAfterFindRouteForMessage>()
				.WithEvent<OnSerializeTransportMessage>()
				.WithEvent<OnAfterSerializeTransportMessage>()
				.WithEvent<OnDispatchTransportMessage>()
				.WithEvent<OnAfterDispatchTransportMessage>();

			RegisterObserver(new FindMessageRouteObserver());
			RegisterObserver(new SerializeTransportMessageObserver());
			RegisterObserver(new DispatchTransportMessageObserver());
		}

		public bool Execute(TransportMessage transportMessage, TransportMessage transportMessageReceived)
		{
			Guard.AgainstNull(transportMessage, "transportMessage");

			State.SetTransportMessage(transportMessage);
			State.SetTransportMessageReceived(transportMessageReceived);

			return base.Execute();
		}

		public override bool Execute()
		{
			throw new NotImplementedException();
		}
	}
}