-- https://www.hackerrank.com/challenges/fp-list-replication/problem


helloWorld 0 = return()
helloWorld num = do
    putStrLn("Hello World")
    helloWorld(num-1)

helloWorldNTimes :: IO()
helloWorldNTimes = do
    num <- readLn
    helloWorld num