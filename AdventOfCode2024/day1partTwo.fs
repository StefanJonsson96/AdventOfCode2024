module AdventOfCode2024.day1partTwo

open day1Input

let main =
    input2
    |> List.groupBy id
    |> List.map (fun (k, v) -> k, List.length v)
    |> Map.ofList
    |> fun similarityMap ->
        input
        |> List.fold (fun acc x -> acc + (x * (Map.tryFind x
            similarityMap |> Option.defaultValue 0))) 0
        |> printfn "%d"
    0