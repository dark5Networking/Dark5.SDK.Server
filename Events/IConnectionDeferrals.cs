using JetBrains.Annotations;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public interface IConnectionDeferrals
	{
		string Message { set; }

		void Defer();

		void ShowCard(string json);

		void Allow();

		void Reject(string message);
	}
}
