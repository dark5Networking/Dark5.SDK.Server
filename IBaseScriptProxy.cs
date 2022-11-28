using CitizenFX.Core;

namespace Dark5.SDK.Server
{
	public interface IBaseScriptProxy
	{
		EventHandlerDictionary EventHandlers { get; }

		ExportDictionary Exports { get; }

		PlayerList Players { get; }
	}
}
