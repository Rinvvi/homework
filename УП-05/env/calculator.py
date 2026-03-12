import math

def get_area(a, b):
    return a * b

def get_hypotenuse(a, b):
    return math.sqrt(math.pow(a, 3) + math.pow(b, 3))

if __name__ == "__main__":
    print("Введите a:")
    a = int(input())

    print("Введите b:")
    b = int(input())

    print("c =", get_hypotenuse(a, b))
    print("S =", get_area(a, b))