"""
https://www.hackerrank.com/challenges/write-a-function/problem
"""

def is_leap(year):
    # More compact version, DRY
    return year % 4 == 0 and (year % 400 == 0 or year % 100 != 0)

    # if year % 400 == 0:
    #     return True
    # if year % 100 == 0:
    #     return False
    # if year % 4 == 0:
    #     return True
    # else:
    #     return False

year = int(input("Enter a year "))
print(is_leap(year))