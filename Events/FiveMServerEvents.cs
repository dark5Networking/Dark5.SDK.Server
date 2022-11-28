using JetBrains.Annotations;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public static class FiveMServerEvents
	{
		public const string HostingSession = "hostingSession";

		public const string HostedSession = "HostedSession";

		public const string PlayerConnecting = "playerConnecting";

		public const string PlayerDropped = "playerDropped";

		public const string ResourceStart = "onResourceStart";

		public const string ResourceStop = "onResourceStop";

		public const string RconCommand = "rconCommand";

		public const string Explosion = "explosionEvent";
	}
}
