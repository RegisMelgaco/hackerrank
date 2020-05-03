open System

(*USER CODE BEGIN*)

let isOdd x = ((abs x) % 2) = 1

let sumWithAccIfOdd acc num =
    if isOdd num then
        acc + num
    else
        acc    

let f arr =
    List.fold sumWithAccIfOdd 0 arr

f [-1; 3; -2]

(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr