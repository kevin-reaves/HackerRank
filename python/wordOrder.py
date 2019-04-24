"""
https://www.hackerrank.com/challenges/word-order/problem
"""

from collections import OrderedDict

if __name__ == '__main__':
    numWords = input("How many words will you input? ")

    words = OrderedDict()
    for x in range(int(numWords)):
        word = input("Enter a word ")
        if word not in words:
            words.setdefault(word, 1)
        else:
            words[word] += 1

    print(len(words.keys()))

    # This unpacking syntax is nice
    # https://docs.python.org/3/tutorial/controlflow.html#unpacking-argument-lists
    print(*words.values())
