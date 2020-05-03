open System

let readConsoleAsList =
    let mutable line = Console.ReadLine()
    let mutable lines = []

    while not (isNull line) do
        lines <- lines @ [line]
        line <- Console.ReadLine()

    lines

let f list =
    List.length list

[<EntryPoint>]
let main argv =
    let list = readConsoleAsList
    let length = f list

    printf "%d" length

    0
