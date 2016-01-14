let multipleOfThreeOrFive a =
    a % 3 = 0 || a % 5 = 0

let answer = 
    [1..999]
    |> Seq.filter multipleOfThreeOrFive
    |> Seq.sum