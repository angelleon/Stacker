import random
import math

def balance(unbalanced, choices, max_num, diff, resp):
    # print(unbalanced, choices, max_num, diff, resp)
    n = len(choices)
    for i in range(n):
        c = choices[i]
        suma = sum(unbalanced)
        suma += c
        if suma == max_num:
            resp.append(c)
            for n in reversed(resp):
                print(n, end=", ")
            print()
            return True
        if suma > max_num:
            return False
        balance(unbalanced + [c], choices[i+1:], max_num, diff - c, resp + [c])
        suma -= c
    return False

def main():
    unbalanced = [3, 4]
    choices = [1,2,7,7]
    unbalanced = [13, 4]
    choices = [1,2,3,6,14]
    max_num = max(unbalanced)
    unbalanced.remove(max_num)
    resp = []
    choices = list(sorted(choices))
    balance(unbalanced, choices, max_num, max_num - sum(unbalanced), resp)

if __name__ == '__main__':
    main()

