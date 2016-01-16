#load "Common.fs"

let answer = 
    Common.primes
    |> Seq.item 10000   // Index is 0-based