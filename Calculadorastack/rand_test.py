#!/usr/bin/env python3

from random import choice
from sys import argv

nums = [i for i in range(10)]
opers = ("+", "-", "*", "/", "%")

def crate_test():
    for i in range(5):
        if i % 2 != 0:
            print(choice(opers), end="")
        else:
            print(choice(nums), end="")


def main():
    n = int(argv[1])
    for _ in range(n):
        crate_test()
        print()


if __name__ == '__main__':
    main()
