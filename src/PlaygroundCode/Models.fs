module Models

type Customer =
    | Person of FirstName: string * LastName: string
    | Company of CompanyName: string
    | Pet of PetName: string

let SampleCustomers =
    [
        // two syntax to create a person
        ("John", "Doe") |> Person
        Person ("Jane", "Doe")
        
        // two syntax to create a company
        Company "Acme Lumber"
        "Acme Mouse Traps" |> Company

        Pet "Snoopy"
    ]