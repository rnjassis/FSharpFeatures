namespace Collections

module CollectionAPI =
    let testList = List.init 20 (fun x -> x*5)

    testList
    |> List.filter (fun x -> x%3 = 0)
    |> List.map (fun x -> x * x)
    |> List.rev

    testList    //return a list that does not have multiples of three
        |> List.fold (fun acc n -> if n%3=0 then acc else n::acc) []

    testList    //the accumulator is always an element on the list
        |>List.reduce (fun acc n -> if n%3=0 then acc else acc+n)
