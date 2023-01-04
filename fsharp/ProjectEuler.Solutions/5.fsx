#load "Common.fs"

// Group the prime factors for the number together and return (factor, count) list...
let getFactorGroups a =
    Common.getFactors a
    |> Seq.groupBy id
    |> Seq.map (fun a -> (fst a, snd a |> Seq.toList |> List.length))
    |> Seq.toList

// Given a list of factors and their arity, select the ones with maximum arity...
let getMaximumArityPrimeFactors (primeList : (int64 * int) list) =
    primeList
    |> List.map (fun a -> fst a)
    |> List.distinct
    |> List.map (fun a -> 
        primeList
        |> List.filter (fun b -> (fst b) = a)
        |> List.sortByDescending (fun b -> snd b)
        |> List.head)
    

let answer =
[2L..20L]
|> Seq.map getFactorGroups                                  // Get the prime factors + arity for each number
|> Seq.toList                                               // Convert to list
|> List.concat                                              // Flatten the list
|> getMaximumArityPrimeFactors                              // Get the factors with maximum arity
|> List.map (fun a -> (float32)(fst a) ** (float32)(snd a)) // Calculate factor^arity for each element
|> List.fold (fun acc elem -> acc * elem) 1.0f              // Multiply all the elements together