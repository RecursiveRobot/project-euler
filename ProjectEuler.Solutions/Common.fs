module Common

let getFactors a =
    let rec getFactorsImp acc curr div =
        match curr with
        | 1L -> acc
        | n -> 
            if curr % div = 0L then
                getFactorsImp (div::acc) (curr/div) div
            else
                getFactorsImp acc curr (div+1L)

    getFactorsImp [] a 2L

