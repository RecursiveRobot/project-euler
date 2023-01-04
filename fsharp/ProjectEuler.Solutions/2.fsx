let infiniteFibonacci = Seq.unfold (fun state ->
    let ``n-2`` = fst state
    let ``n-1`` = snd state
    let n = ``n-2`` + ``n-1``
    Some(n, (``n-1``, n))) (0,1)

let answer = 
    infiniteFibonacci
    |> Seq.takeWhile (fun a -> a < 4000000)
    |> Seq.filter (fun a -> a % 2 = 0) 
    |> Seq.sum