{-# OPTIONS_GHC -Wno-incomplete-patterns #-}
{-# LANGUAGE ParallelListComp #-}

module Common 
    ( sieve
    , hasFactor
    )
where

import Data.List
import qualified Data.Map as Map

hasFactor :: Int -> Int -> Bool
hasFactor l r = l `mod` r == 0

sieve2 = [x | x <- [2..], and [x `mod` y /= 0 | y <- [2..floor(sqrt(fromIntegral x))]]]

sieve xs = sieve' xs Map.empty
sieve' [] table = []
sieve' (x:xs) table =
  case Map.lookup x table of
    Nothing -> x: sieve' xs (Map.insert (x*x) [x] table)
    Just facts -> sieve' xs (foldl' reinsert (Map.delete x table) facts)
      where reinsert table prime = Map.insertWith (++) (x+prime) [prime] table

primes = 2 : sieve [3,5..]