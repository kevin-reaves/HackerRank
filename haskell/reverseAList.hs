-- https://www.hackerrank.com/challenges/fp-reverse-a-list/problem



-- couldn't figure out how to replicate the input that HR was putting out.
-- Decided to just include the solution here
rev:: [Int] -> [Int]
rev l = last l : rev(init l)