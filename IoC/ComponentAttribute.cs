using System;
using JetBrains.Annotations;

namespace Dark5.SDK.Server.IoC
{
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
	public class ComponentAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets lifetime
		/// </summary>
		public Lifetime Lifetime { get; set; } = Lifetime.Transient;
	}
}
