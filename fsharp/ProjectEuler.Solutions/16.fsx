open System

let sumOfDigits n =
    ((string)(n)).ToCharArray()
    |> Seq.map (fun a -> Int32.Parse(a.ToString()))
    |> Seq.fold (fun acc elem -> acc + elem) 0

let answer =
    2I**1000
    |> sumOfDigits
    
