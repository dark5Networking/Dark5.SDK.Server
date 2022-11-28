using JetBrains.Annotations;

namespace Dark5.SDK.Server.IoC
{
	/// <summary>Lifetime of an object</summary>
	[PublicAPI]
	public enum Lifetime
	{
		/// <summary>Return a new object each time the service is request.</summary>
		Transient,

		/// <summary>Same instance for the entire application lifetime.</summary>
		Singleton
	}
}
