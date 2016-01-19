module Common

let primeFactors a =
    let rec primeFactorsImp acc curr div =
        match curr with
        | 1L -> acc
        | n -> 
            if curr % div = 0L then
                primeFactorsImp (div::acc) (curr/div) div
            else
                primeFactorsImp acc curr (div+1L)

    primeFactorsImp [] a 2L

let primes =
    let rec primesImp (acc : int list) (a : int) = seq {
        if acc |> List.forall (fun b -> a % b > 0) then
           yield a
           yield! primesImp (a::acc) (a+1)
        else
            yield! primesImp acc (a+1)
    }
    primesImp [] 2

let factorial (n : int) =
    let rec factorialImp acc elem = 
        if elem = new bigint(n) then
            acc
        else
           factorialImp (acc * (elem+1I)) (elem+1I)

    factorialImp 1I 1I
