"""
https://www.hackerrank.com/challenges/compress-the-string/problem
"""
from itertools import groupby

if __name__ == '__main__':
    numbers = input("Input a string to be compressed ")
    for key, group in groupby(numbers):
        print("({}, {})".format(len(list(group)), key), end=" ")

