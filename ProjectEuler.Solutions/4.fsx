let ``All products of two 3-digit numbers`` = seq { 
    for x in 100 .. 999 do
         for y in 100 .. 999 do
           yield x * y
}
    
let isPalindrome a =
    string a = new string(Array.rev((string a).ToCharArray()))

``All products of two 3-digit numbers``
|> Seq.filter isPalindrome
|> Seq.max