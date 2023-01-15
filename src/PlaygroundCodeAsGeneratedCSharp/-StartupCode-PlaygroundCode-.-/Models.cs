using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.FSharp.Collections;
using PlaygroundCode;

namespace _003CStartupCode_0024PlaygroundCode_003E._0024PlaygroundCode;

internal static class Models
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static readonly FSharpList<PlaygroundCode.Models.Customer> SampleCustomers_00408;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal static int init_0040;

	static Models()
	{
		Tuple<string, string> tuple = new Tuple<string, string>("John", "Doe");
		Tuple<string, string> tuple2 = tuple;
		string item = tuple2.Item1;
		string item2 = tuple2.Item2;
		PlaygroundCode.Models.Customer head = PlaygroundCode.Models.Customer.NewPerson(item, item2);
		PlaygroundCode.Models.Customer head2 = PlaygroundCode.Models.Customer.NewPerson("Jane", "Doe");
		PlaygroundCode.Models.Customer head3 = PlaygroundCode.Models.Customer.NewCompany("Acme Lumber");
		string text = "Acme Mouse Traps";
		string companyName = text;
		FSharpList<PlaygroundCode.Models.Customer> SampleCustomers = (SampleCustomers_00408 = FSharpList<PlaygroundCode.Models.Customer>.Cons(head, FSharpList<PlaygroundCode.Models.Customer>.Cons(head2, FSharpList<PlaygroundCode.Models.Customer>.Cons(head3, FSharpList<PlaygroundCode.Models.Customer>.Cons(PlaygroundCode.Models.Customer.NewCompany(companyName), FSharpList<PlaygroundCode.Models.Customer>.Cons(PlaygroundCode.Models.Customer.NewPet("Snoopy"), FSharpList<PlaygroundCode.Models.Customer>.Empty))))));
	}
}
