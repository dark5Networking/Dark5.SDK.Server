using JetBrains.Annotations;
using Dark5.SDK.Server.Communications;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public class ClientDeferralsEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public IConnectionDeferrals Deferrals { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientDeferralsEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientDeferralsEventArgs(IClient client, IConnectionDeferrals deferrals) : base(client)
		{
			this.Deferrals = deferrals;
		}
	}
}
