"""
https://www.hackerrank.com/challenges/most-commons/problem
"""

from collections import Counter

if __name__ == '__main__':
    # companyName = input()
    companyName = "Google"
    companyLogo = ""
    sortName = sorted(companyName.lower())
    for item in Counter(sortName).most_common(3):
        companyLogo += item[0]
        # print(item)
    print(companyLogo.upper())