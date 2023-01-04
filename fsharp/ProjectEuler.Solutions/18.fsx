open System

let input = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"

type Tree = int [] []

let tree : Tree =
    input.Split([|"\n"|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.toArray
    |> Array.map (fun a -> 
        a.Split([|" "|], StringSplitOptions.RemoveEmptyEntries) 
        |> Seq.map (fun a -> Int32.Parse(a)) 
        |> Seq.toArray)


let possiblePaths =
    let rec possiblePathsImpl currentNode path  = seq {
        let fullPath = tree.[fst currentNode].[snd currentNode] :: path

        if fst currentNode < tree.Length - 1 then
            yield! possiblePathsImpl (fst currentNode + 1, snd currentNode) fullPath
            yield! possiblePathsImpl (fst currentNode + 1, snd currentNode + 1) fullPath
        else
            yield fullPath
    }
    possiblePathsImpl (0,0) []


let answer = 
    possiblePaths
    |> Seq.map (Seq.sum)
    |> Seq.max