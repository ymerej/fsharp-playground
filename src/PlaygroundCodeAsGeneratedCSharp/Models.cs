using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _003CStartupCode_0024PlaygroundCode_003E;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

[CompilationMapping(SourceConstructFlags.Module)]
public static class Models
{
	[Serializable]
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	[DebuggerDisplay("{__DebugDisplay(),nq}")]
	[CompilationMapping(SourceConstructFlags.SumType)]
	public abstract class Customer : IEquatable<Customer>, IStructuralEquatable, IComparable<Customer>, IComparable, IStructuralComparable
	{
		public static class Tags
		{
			public const int Person = 0;

			public const int Company = 1;
		}

		[Serializable]
		[SpecialName]
		[DebuggerTypeProxy(typeof(Person_0040DebugTypeProxy))]
		[DebuggerDisplay("{__DebugDisplay(),nq}")]
		public class Person : Customer
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			internal readonly string firstName;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			internal readonly string lastName;

			[CompilationMapping(SourceConstructFlags.Field, 0, 0)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string FirstName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return firstName;
				}
			}

			[CompilationMapping(SourceConstructFlags.Field, 0, 1)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string LastName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return lastName;
				}
			}

			[CompilerGenerated]
			[DebuggerNonUserCode]
			internal Person(string firstName, string lastName)
			{
				this.firstName = firstName;
				this.lastName = lastName;
			}
		}

		[Serializable]
		[SpecialName]
		[DebuggerTypeProxy(typeof(Company_0040DebugTypeProxy))]
		[DebuggerDisplay("{__DebugDisplay(),nq}")]
		public class Company : Customer
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			internal readonly string companyName;

			[CompilationMapping(SourceConstructFlags.Field, 1, 0)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string CompanyName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return companyName;
				}
			}

			[CompilerGenerated]
			[DebuggerNonUserCode]
			internal Company(string companyName)
			{
				this.companyName = companyName;
			}
		}

		[SpecialName]
		internal class Person_0040DebugTypeProxy
		{
			[CompilationMapping(SourceConstructFlags.Field, 0, 0)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string FirstName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return _obj.firstName;
				}
			}

			[CompilationMapping(SourceConstructFlags.Field, 0, 1)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string LastName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return _obj.lastName;
				}
			}

			[CompilerGenerated]
			[DebuggerNonUserCode]
			public Person_0040DebugTypeProxy(Person obj)
			{
				_obj = obj;
			}
		}

		[SpecialName]
		internal class Company_0040DebugTypeProxy
		{
			[CompilationMapping(SourceConstructFlags.Field, 1, 0)]
			[CompilerGenerated]
			[DebuggerNonUserCode]
			public string CompanyName
			{
				[CompilerGenerated]
				[DebuggerNonUserCode]
				get
				{
					return _obj.companyName;
				}
			}

			[CompilerGenerated]
			[DebuggerNonUserCode]
			public Company_0040DebugTypeProxy(Company obj)
			{
				_obj = obj;
			}
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Tag
		{
			[CompilerGenerated]
			[DebuggerNonUserCode]
			get
			{
				return (this is Company) ? 1 : 0;
			}
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool IsPerson
		{
			[CompilerGenerated]
			[DebuggerNonUserCode]
			get
			{
				return this is Person;
			}
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool IsCompany
		{
			[CompilerGenerated]
			[DebuggerNonUserCode]
			get
			{
				return this is Company;
			}
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal Customer()
		{
		}

		[CompilationMapping(SourceConstructFlags.UnionCase, 0)]
		public static Customer NewPerson(string firstName, string lastName)
		{
			return new Person(firstName, lastName);
		}

		[CompilationMapping(SourceConstructFlags.UnionCase, 1)]
		public static Customer NewCompany(string companyName)
		{
			return new Company(companyName);
		}

		[SpecialName]
		[CompilerGenerated]
		[DebuggerNonUserCode]
		internal object __DebugDisplay()
		{
			return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<Customer, string>, Unit, string, string, string>("%+0.8A")).Invoke(this);
		}

		[CompilerGenerated]
		public override string ToString()
		{
			return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<Customer, string>, Unit, string, string, Customer>("%+A")).Invoke(this);
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override int CompareTo(Customer obj)
		{
			if (this != null)
			{
				if (obj != null)
				{
					int num = ((this is Company) ? 1 : 0);
					int num2 = ((obj is Company) ? 1 : 0);
					if (num == num2)
					{
						if (this is Person)
						{
							Person person = (Person)this;
							Person person2 = (Person)obj;
							IComparer genericComparer = LanguagePrimitives.GenericComparer;
							int num3 = string.CompareOrdinal(person.firstName, person2.firstName);
							if (num3 < 0)
							{
								return num3;
							}
							if (num3 > 0)
							{
								return num3;
							}
							IComparer genericComparer2 = LanguagePrimitives.GenericComparer;
							return string.CompareOrdinal(person.lastName, person2.lastName);
						}
						Company company = (Company)this;
						Company company2 = (Company)obj;
						IComparer genericComparer3 = LanguagePrimitives.GenericComparer;
						return string.CompareOrdinal(company.companyName, company2.companyName);
					}
					return num - num2;
				}
				return 1;
			}
			if (obj != null)
			{
				return -1;
			}
			return 0;
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override int CompareTo(object obj)
		{
			return CompareTo((Customer)obj);
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override int CompareTo(object obj, IComparer comp)
		{
			Customer customer = (Customer)obj;
			if (this != null)
			{
				if ((Customer)obj != null)
				{
					int num = ((this is Company) ? 1 : 0);
					Customer customer2 = customer;
					int num2 = ((customer2 is Company) ? 1 : 0);
					if (num == num2)
					{
						if (this is Person)
						{
							Person person = (Person)this;
							Person person2 = (Person)customer;
							int num3 = string.CompareOrdinal(person.firstName, person2.firstName);
							if (num3 < 0)
							{
								return num3;
							}
							if (num3 > 0)
							{
								return num3;
							}
							return string.CompareOrdinal(person.lastName, person2.lastName);
						}
						Company company = (Company)this;
						Company company2 = (Company)customer;
						return string.CompareOrdinal(company.companyName, company2.companyName);
					}
					return num - num2;
				}
				return 1;
			}
			if ((Customer)obj != null)
			{
				return -1;
			}
			return 0;
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override int GetHashCode(IEqualityComparer comp)
		{
			if (this != null)
			{
				int num = 0;
				if (this is Person)
				{
					Person person = (Person)this;
					num = 0;
					num = -1640531527 + ((person.lastName?.GetHashCode() ?? 0) + ((num << 6) + (num >> 2)));
					return -1640531527 + ((person.firstName?.GetHashCode() ?? 0) + ((num << 6) + (num >> 2)));
				}
				Company company = (Company)this;
				num = 1;
				return -1640531527 + ((company.companyName?.GetHashCode() ?? 0) + ((num << 6) + (num >> 2)));
			}
			return 0;
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override int GetHashCode()
		{
			return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override bool Equals(object obj, IEqualityComparer comp)
		{
			if (this != null)
			{
				if (obj is Customer customer)
				{
					Customer customer2 = customer;
					int num = ((this is Company) ? 1 : 0);
					Customer customer3 = customer2;
					int num2 = ((customer3 is Company) ? 1 : 0);
					if (num == num2)
					{
						if (this is Person)
						{
							Person person = (Person)this;
							Person person2 = (Person)customer2;
							if (string.Equals(person.firstName, person2.firstName))
							{
								return string.Equals(person.lastName, person2.lastName);
							}
							return false;
						}
						Company company = (Company)this;
						Company company2 = (Company)customer2;
						return string.Equals(company.companyName, company2.companyName);
					}
					return false;
				}
				return false;
			}
			return obj == null;
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override bool Equals(Customer obj)
		{
			if (this != null)
			{
				if (obj != null)
				{
					int num = ((this is Company) ? 1 : 0);
					int num2 = ((obj is Company) ? 1 : 0);
					if (num == num2)
					{
						if (this is Person)
						{
							Person person = (Person)this;
							Person person2 = (Person)obj;
							if (string.Equals(person.firstName, person2.firstName))
							{
								return string.Equals(person.lastName, person2.lastName);
							}
							return false;
						}
						Company company = (Company)this;
						Company company2 = (Company)obj;
						return string.Equals(company.companyName, company2.companyName);
					}
					return false;
				}
				return false;
			}
			return obj == null;
		}

		[CompilerGenerated]
		[DebuggerNonUserCode]
		public sealed override bool Equals(object obj)
		{
			if (obj is Customer obj2)
			{
				return Equals(obj2);
			}
			return false;
		}
	}

	[CompilationMapping(SourceConstructFlags.Value)]
	public static FSharpList<Customer> SampleCustomers => _0024Models.SampleCustomers_00407;
}
