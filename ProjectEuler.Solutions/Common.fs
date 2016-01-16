module Common

let getPrimeFactors a =
    let rec getPrimeFactorsImp acc curr div =
        match curr with
        | 1L -> acc
        | n -> 
            if curr % div = 0L then
                getPrimeFactorsImp (div::acc) (curr/div) div
            else
                getPrimeFactorsImp acc curr (div+1L)

    getPrimeFactorsImp [] a 2L

