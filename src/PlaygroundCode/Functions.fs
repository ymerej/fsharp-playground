module PlaygroundCode.Functions

// declare a function signature, basically the same thing as creating a delegate in C#
type StringManipulationStrategy = string -> string

let toLower : StringManipulationStrategy =
    fun str ->
        str.ToLower()

let toUpper : StringManipulationStrategy =
    fun str ->
        str.ToUpper()
        
// This does the same thing as toUpper
let toUpperImplied (str: string) = str.ToUpper()
                
let chooseStrategy (str : string) : StringManipulationStrategy =
    if (str.Length % 2 = 0) then toUpperImplied else toLower
    
let runStrategy str =
    let strategy = chooseStrategy str
    str |> strategy |> printfn "After strategy: %s"
    

let reverse (str : string) =
    let reversed = str.ToCharArray() |> Array.rev 
    System.String(reversed)
    
let decoratorPattern = toLower >> reverse

let runDecorator str =
    str |> decoratorPattern |> printfn "After decorator: %s"
