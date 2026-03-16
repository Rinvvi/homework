import math

def get_hypotenuse(a, b):
    return math.sqrt(math.pow(a, 3) + math.pow(b, 3))

if __name__ == "__main__":
    a = 1
    b = 2
    print(get_hypotenuse(a,b))
