using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Dark5.SDK.Server.Rcon
{
	[PublicAPI]
	public interface IRconManager
	{
		void Register(string command, Action callback);

		void Register(string command, Action<string> callback);

		void Register(string command, Action<IEnumerable<string>> callback);
	}
}
