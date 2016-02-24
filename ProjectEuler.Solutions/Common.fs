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
        if elem = n then
            acc
        else
           factorialImp (acc * new bigint(elem+1)) (elem+1)

    factorialImp 1I 1

let factors n = seq {
    for i in 1 .. n-1 do
        if n % i = 0 then
            yield i
}