#load "Common.fs"

open Common
open System

let answer =
    factorial 100
    |> string
    |> Seq.fold (fun acc elem -> 
        match Int32.TryParse (elem |> string) with 
           | (true, value) -> acc + value
           | _ -> acc) 0
