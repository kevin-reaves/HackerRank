-- https://www.hackerrank.com/challenges/fp-list-replication/problem

f:: Int -> [Int] -> [Int]
f n arr = filter (\x -> x < n) arr

# doesn't like to be printed with ghci, need to compile with ghc
main = do
    n <- readLn :: IO Int
    inputdata <- getContents
    let 
        numbers = map read (lines inputdata) :: [Int]
    let newNumbers =  (map show . f n ) numbers
    print(newNumbers)