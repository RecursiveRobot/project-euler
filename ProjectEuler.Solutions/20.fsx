#load "Common.fs"

open Common
open System

let answer =
    factorial 100
    |> string
    |> Seq.fold (fun acc elem -> 
        match Int32.TryParse (elem |> string) with 
           | (true, value) -> acc + value
           | _ -> failwith "Non-numeric character found in input string") 0
