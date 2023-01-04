#load "Common.fs"

let answer =
    Common.primes
    |> Seq.takeWhile (fun a -> a < 2000000)
    |> Seq.fold (fun acc elem -> acc + (int64)elem) 0L