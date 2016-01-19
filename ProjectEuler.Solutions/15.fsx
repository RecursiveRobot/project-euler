#load "Common.fs"

// This is a straight-forward multiset permutation...
// We have 20 rights and 20 downs to pick with only the order mattering

// So answer =

//   n*2!
// ---------
// (n)!*(n)!

let latticePathsCount n =
    (Common.factorial (2*n)) / ((Common.factorial n) * (Common.factorial n))

let answer =
    latticePathsCount 20

