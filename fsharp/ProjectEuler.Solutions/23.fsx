#load "Common.fs"

open Common
open System

let abundantNumbers = seq {
    for i in 12 .. Int32.MaxValue do
        if Seq.sum (factors i) > i then
                yield i
}

let canBeExpressedAsSumOfValues x xs =
    let rec canBeExpressedAsSumOfValuesImpl x xs =
        if x = 0 then
            true
        elif x < Seq.min xs then
            false
        else
            xs
            |> Seq.filter (fun a -> a <= x)
            |> Seq.exists (fun a -> canBeExpressedAsSumOfValuesImpl (x - a) xs)

    if Seq.isEmpty xs then
        false
    else
        canBeExpressedAsSumOfValuesImpl x xs

let abundantNumbersLessThan28123 =
    abundantNumbers
    |> Seq.takeWhile (fun a -> a < 28123)
    |> Seq.sortBy (fun a -> -a)
    |> Seq.toList

let answer =
    [1..28123]
    |> Seq.filter (fun a -> not (canBeExpressedAsSumOfValues a abundantNumbersLessThan28123))
    |> Seq.sum

        