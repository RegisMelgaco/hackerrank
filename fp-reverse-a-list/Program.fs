// Learn more about F# at http://fsharp.org

open System

let reverseList l =
    List.rev l

let readConsoleAsList =
    let mutable line = Console.ReadLine()
    let mutable lines = []

    while not (isNull line) do
        lines <- lines @ [line]
        line <- Console.ReadLine()

    lines

[<EntryPoint>]
let main argv =
    let values = readConsoleAsList
    for v in (reverseList values) do
        printfn "%s" v

    0
