#load "Common.fs"

open Common
open System

let sumOfFactors n =
    factors n
    |> Seq.sum

let amicableNumbers inputMap =
    inputMap
    |> Map.filter (fun a b -> 
            inputMap.ContainsKey inputMap.[a] 
            && inputMap.[inputMap.[a]] = a 
            && inputMap.[a] <> a)
    |> Map.toSeq
    |> Seq.map snd

let answer =
    [1..9999]
    |> Seq.map (fun a -> (a, sumOfFactors a))
    |> Map.ofSeq
    |> amicableNumbers
    |> Seq.sum