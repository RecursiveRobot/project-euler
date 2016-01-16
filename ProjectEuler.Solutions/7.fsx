#load "Common.fs"

let primes =
    let rec primeImp (acc : int list) (a : int) = seq {
        if acc |> List.forall (fun b -> a % b > 0) then
           yield a
           yield! primeImp (a::acc) (a+1)
        else
            yield! primeImp acc (a+1)
    }
    primeImp [] 2

let answer = 
    primes
    |> Seq.item 10000   // Index is 0-based
    
