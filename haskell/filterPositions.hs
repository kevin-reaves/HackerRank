-- https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list/problem

f :: [Int] -> [Int]

-- !! is the indexing operator
f lst = map (lst !!) [1,3..length lst - 1]

-- This part deals with the Input and Output and can be used as it is. Do not modify it.
main = do
    inputdata <- getContents
    let 
        numbers = map read (lines inputdata) :: [Int]
    let newNumbers =  (map show . f ) numbers
    print(newNumbers)