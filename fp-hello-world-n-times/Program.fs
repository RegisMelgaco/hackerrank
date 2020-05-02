// Learn more about F# at http://fsharp.org

open System

let sayHelloN times =
    List.init times (function _ -> "Hello World")

[<EntryPoint>]
let main argv =
    let times = Console.ReadLine() |> int

    let messages = sayHelloN times

    for message in messages do
        printfn "%s" message

    0
