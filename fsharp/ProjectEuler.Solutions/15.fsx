#load "Common.fs"

// This is a straight-forward multiset permutation...
// We have 20 rights and 20 downs to pick, with the order mattering

// So answer =

//  (w + h)!
// -----------
// (w)! * (h)!
// where w = grid width and h = grid height

let latticePathsCount w h =
    (Common.factorial (w+h)) / ((Common.factorial w) * (Common.factorial h))

let answer =
    latticePathsCount 20 20

