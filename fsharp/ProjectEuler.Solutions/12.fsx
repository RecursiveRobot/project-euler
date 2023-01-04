#load "Common.fs"

let triangleNumbers = Seq.initInfinite id |> Seq.map (fun a -> (int64)a) |> Seq.scan (+) 0L |> Seq.skip 2

let isTriangleNumber (a : int64) =
    triangleNumbers
    |> Seq.takeWhile (fun b -> b <= a)
    |> Seq.exists (fun c -> c = a)

let numberOfFactors' a =
    Common.primeFactors a
    |> Seq.groupBy id
    |> Seq.fold (fun acc elem -> acc * (Seq.length (snd elem) + 1)) 1

let bruteForceAnswer =
    triangleNumbers
    |> Seq.find (fun a -> numberOfFactors' a > 500)