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


getFactors 600851475143L                                        // Get all the factors for the number
|> Seq.groupBy (fun a -> a)                                     // Group them together
|> Seq.map (fun a -> (fst a, ((snd a) |> Seq.toList).Length))   // Map the groupings to get (factor, count) tuple
|> Seq.find (fun a -> snd a = 1)                                // Get the first prime factor
|> fst                                                          // Return the factor itself