namespace Shuttle.ESB.Core
{
	public static class StateKeys
	{
		public const string ActiveState = "ActiveState";
		public const string AvailableWorker = "AvailableWorker";
		public const string CheckpointMessageId = "CheckpointMessageId";
		public const string DeferredMessageReturned = "DeferredMessageReturned";
		public const string DeferredQueue = "DeferredQueue";
		public const string DurationToIgnoreOnFailure = "DurationToIgnoreOnFailure";
		public const string ErrorQueue = "ErrorQueue";
		public const string HandlerContext = "HandlerContext";
		public const string MaximumFailureCount = "MaximumFailureCount";
		public const string Message = "Message";
		public const string MessageBytes = "MessageBytes";
		public const string MessageHandler = "MessageHandler";
		public const string NextDeferredProcessDate = "NextDeferredProcessDate";
		public const string ReceivedMessage = "ReceivedMessage";
		public const string TransactionComplete = "TransactionComplete";
		public const string TransactionScope = "TransactionScope";
		public const string TransportMessage = "TransportMessage";
		public const string TransportMessageConfigurator = "TransportMessageConfigurator";
		public const string TransportMessageReceived = "TransportMessageReceived";
		public const string TransportMessageStream = "TransportMessageStream";
		public const string Working = "Working";
		public const string WorkQueue = "WorkQueue";
	}
}