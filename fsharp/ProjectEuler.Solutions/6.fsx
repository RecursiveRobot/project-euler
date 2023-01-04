let sumOfFirst100Squares =
    [1..100]
    |> Seq.fold (fun acc elem -> acc + (elem * elem)) 0

let sumOfFirst100Numbers =
    [1..100]
    |> Seq.fold (fun acc elem -> acc + elem) 0

let answer = sumOfFirst100Numbers * sumOfFirst100Numbers - sumOfFirst100Squares