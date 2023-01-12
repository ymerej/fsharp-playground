using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.FSharp.Collections;

namespace _003CStartupCode_0024PlaygroundCode_003E;

internal static class _0024Models
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal static readonly FSharpList<Models.Customer> SampleCustomers_00407;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal static int init_0040;

	static _0024Models()
	{
		Tuple<string, string> tuple = new Tuple<string, string>("John", "Doe");
		Tuple<string, string> tuple2 = tuple;
		string item = tuple2.Item1;
		string item2 = tuple2.Item2;
		Models.Customer head = Models.Customer.NewPerson(item, item2);
		Models.Customer head2 = Models.Customer.NewPerson("Jane", "Doe");
		Models.Customer head3 = Models.Customer.NewCompany("Acme Lumber");
		string text = "Acme Mouse Traps";
		string companyName = text;
		FSharpList<Models.Customer> SampleCustomers = (SampleCustomers_00407 = FSharpList<Models.Customer>.Cons(head, FSharpList<Models.Customer>.Cons(head2, FSharpList<Models.Customer>.Cons(head3, FSharpList<Models.Customer>.Cons(Models.Customer.NewCompany(companyName), FSharpList<Models.Customer>.Empty)))));
	}
}
