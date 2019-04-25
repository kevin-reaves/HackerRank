"""
https://www.hackerrank.com/challenges/find-angle/problem
"""

import math
def findAngleMBC(AB, BC):
    AC = math.sqrt((AB**2) + (BC**2))
    return round(math.degrees(math.asin(AB/AC)))

if __name__ == '__main__':
    AB = 10
    BC = 10
    print(str(findAngleMBC(AB, BC)) + "°")
