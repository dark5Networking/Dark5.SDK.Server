using System;
using JetBrains.Annotations;
using Dark5.SDK.Server.Communications;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public class ClientEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the client.
		/// </summary>
		/// <value>
		/// The client.
		/// </value>
		public IClient Client { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		public ClientEventArgs(IClient client)
		{
			this.Client = client;
		}
	}
}
