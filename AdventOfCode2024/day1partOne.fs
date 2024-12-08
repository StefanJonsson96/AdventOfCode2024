module AdventOfCode2024.day1partOne

open day1Input

let main  = 
    input
    |> List.sort
    |> fun sorted1 -> 
        let sorted2 = List.sort input2
        List.map2 (fun x y -> abs (x - y)) sorted1 sorted2
    |> List.sum
    |> printfn "%d"
    0