"""
https://www.hackerrank.com/challenges/the-minion-game/problem
"""


def minion_game(s):
    v = 'AEIOU'
    stuart, kevin, ln = 0, 0, len(s)

    for i in range(ln):
        if s[i] in v:
            kevin += (ln - i)
        else:
            stuart += (ln - i)

    if stuart > kevin:
        print('Stuart', stuart)
    elif stuart == kevin:
        print('Draw')
    else:
        print('Kevin', kevin)


if __name__ == '__main__':
    s = input("Enter a string to play the minion game ").upper()
    minion_game(s)