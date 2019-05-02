-- https://www.hackerrank.com/challenges/fp-sum-of-odd-elements/problem

f arr = sum (filter(\x -> x `mod` 2 /= 0) arr)

-- doesn't like to be printed with ghci, need to compile with ghc
main::IO()
main = do
        inputdata <- getContents
        let 
            numbers = map read (lines inputdata) :: [Int]
        let
            newNumbers =  f numbers
        print(newNumbers)
