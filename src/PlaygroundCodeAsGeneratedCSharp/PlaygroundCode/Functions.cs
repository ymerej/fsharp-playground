using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.FSharp.Core;

namespace PlaygroundCode;

[CompilationMapping(SourceConstructFlags.Module)]
public static class Functions
{
	[Serializable]
	internal sealed class chooseStrategy_004018 : FSharpFunc<string, string>
	{
		internal static readonly chooseStrategy_004018 @_instance = new chooseStrategy_004018();

		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal chooseStrategy_004018()
		{
		}

		public override string Invoke(string str)
		{
			return toUpperImplied(str);
		}
	}

	[Serializable]
	internal sealed class chooseStrategy_004018_002D1 : FSharpFunc<string, string>
	{
		internal static readonly chooseStrategy_004018_002D1 @_instance = new chooseStrategy_004018_002D1();

		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal chooseStrategy_004018_002D1()
		{
		}

		public override string Invoke(string str)
		{
			return toLower(str);
		}
	}

	public static string toUpper(string str)
	{
		return str.ToUpper();
	}

	public static string toUpperImplied(string str)
	{
		return str.ToUpper();
	}

	public static string toLower(string str)
	{
		return str.ToLower();
	}

	public static FSharpFunc<string, string> chooseStrategy(string str)
	{
		if (str.Length % 2 == 0)
		{
			return chooseStrategy_004018.@_instance;
		}
		return chooseStrategy_004018_002D1.@_instance;
	}

	public static void runStrategy(string str)
	{
		FSharpFunc<string, string> strategy = chooseStrategy(str);
		string text = strategy.Invoke(str);
		FSharpFunc<string, Unit> fSharpFunc = ExtraTopLevelOperators.PrintFormatLine(new PrintfFormat<FSharpFunc<string, Unit>, TextWriter, Unit, Unit, string>("After strategy: %s"));
		string func = text;
		fSharpFunc.Invoke(func);
	}
}
