open Models

// For more information see https://aka.ms/fsharp-console-apps

let customers = SampleCustomers

let printCustomer (customer : Customer) =
    match customer with 
    | Person (firstName, lastName) -> printfn "Person named %s, %s" lastName firstName
    | Company name -> printfn "Company named %s" name

    // FSharp creates FS0025 as a warning.  
    //  By making it an error the compiler will require you to implement all cases
    //    which is a nice capability since it will eliminate runtime errors later.
    | Pet name -> printfn "Pet named %s" name

customers
|> Seq.iter printCustomer
