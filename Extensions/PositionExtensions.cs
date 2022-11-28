using JetBrains.Annotations;
using Dark5.SDK.Core.Models;

namespace Dark5.SDK.Server.Extensions
{
	[PublicAPI]
	public static class PositionExtensions
	{
		public static CitizenFX.Core.Vector3 ToCitVector3(this Position position) => new CitizenFX.Core.Vector3(position.X, position.Y, position.Z);
	}
}
