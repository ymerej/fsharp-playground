// See https://aka.ms/new-console-template for more information
using PlaygroundCode;

var customers = Models.SampleCustomers;

void PrintCustomer(Models.Customer customer)
{
    switch (customer)
    {
        case Models.Customer.Company company:
            Console.WriteLine($"Company named {company.CompanyName}");
            break;
        case Models.Customer.Person person:
            Console.WriteLine($"Person named {person.LastName}, {person.FirstName}");
            break;
        
        // what about Pet? C# just ignores it.  Is that a good thing or a bad thing?
    }
}

customers.ToList().ForEach(PrintCustomer);