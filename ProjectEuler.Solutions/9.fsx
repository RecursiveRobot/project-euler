let first (c, _, _) = c
let second (_, c, _) = c
let third (_, _, c) = c

let isPythagoreanTriplet input =
    let a = first input
    let b = second input
    let c = third input
    
    a*a + b*b = c*c

let allCandidatesAddingUpTo1000 = seq {
    for a in 1 .. 995 do
         for b in 2 .. 996 do
            for c in 3 .. 997 do
                if (a + b + c = 1000) then
                    yield (a,b,c)
}

let answer = 
    allCandidatesAddingUpTo1000
    |> Seq.find isPythagoreanTriplet
    |> (fun a -> first a * second a * third a)
