module Tests

open System
open Xunit
open MBrace.FsPickler.Json
open Xunit.Abstractions

type PickleTests(output : ITestOutputHelper) =

    [<Fact>]
    member __.``When and array has multiple customer types, then serialize the results`` () =

        let serializer = FsPickler.CreateJsonSerializer()
        serializer.PickleToString PlaygroundCode.Models.SampleCustomers |> sprintf "%s" |> output.WriteLine
        
        Assert.True(true)