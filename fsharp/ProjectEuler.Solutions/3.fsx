#load "Common.fs"

Common.getFactors 600851475143L                                 // Get all the factors for the number
|> Seq.groupBy (fun a -> a)                                     // Group them together
|> Seq.map (fun a -> (fst a, ((snd a) |> Seq.toList).Length))   // Map the groupings to get (factor, count) tuple
|> Seq.find (fun a -> snd a = 1)                                // Get the first prime factor
|> fst                                                          // Return the factor itself