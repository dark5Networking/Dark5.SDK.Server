using JetBrains.Annotations;
using Dark5.SDK.Core.Models.Player;
using Dark5.SDK.Server.Communications;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionDeferralsEventArgs : ClientSessionEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public IConnectionDeferrals Deferrals { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientSessionDeferralsEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="session">The session.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientSessionDeferralsEventArgs(IClient client, Session session, IConnectionDeferrals deferrals) : base(client, session)
		{
			this.Deferrals = deferrals;
		}
	}
}
