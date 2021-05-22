using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Temp.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new Temp.App(), args);
		host.Run();
	}
}
}
