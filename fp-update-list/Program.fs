// Learn more about F# at http://fsharp.org

open System

let f arr =
    List.map
        abs
        arr

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

[<EntryPoint>]
let main argv =
    print_out(f input)
    printfn "Hello World from F#!"
    0 // return an integer exit code
