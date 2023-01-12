using System.IO;
using Microsoft.FSharp.Core;

namespace PlaygroundCode;

[CompilationMapping(SourceConstructFlags.Module)]
public static class Say
{
	public static void hello(string name)
	{
		ExtraTopLevelOperators.PrintFormatLine(new PrintfFormat<FSharpFunc<string, Unit>, TextWriter, Unit, Unit, string>("Hello %s")).Invoke(name);
	}
}
