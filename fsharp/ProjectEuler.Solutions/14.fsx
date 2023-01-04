let collatzSequenceLength a =
    let rec collatzSequenceLengthImp acc elem =
        match elem with
        | 1L -> acc
        | n when n%2L = 0L -> collatzSequenceLengthImp (acc+1L) (n/2L)
        | n -> collatzSequenceLengthImp (acc+1L) (3L*n + 1L)

    collatzSequenceLengthImp 0L a

let answer =
    [1L..1000000L]
    |> Seq.maxBy collatzSequenceLength