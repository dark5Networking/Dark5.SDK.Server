using JetBrains.Annotations;
using Dark5.SDK.Core.Models;

namespace Dark5.SDK.Server.Events
{
	[PublicAPI]
	public interface IExplosionEvent
	{
		int OwnerNetId { get; }

		int ExplosionType { get; }

		float DamageScale { get; }

		float CameraShake { get; }

		Position Position { get; }

		bool IsAudible { get; }

		bool IsInvisible { get; }

		void Cancel();
	}
}
