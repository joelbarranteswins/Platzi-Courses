import random

# mencionar el curso actual de algoritmos

def binary_search(data, target, low, high):
    if low > high:
        return False
  
    mid = (low + high) // 2

    if target == data[mid]:
        return True
    elif target < data[mid]:
        return binary_search(data, target, low, mid - 1)
    else:
        return binary_search(data, target, mid + 1, high)


if __name__ == '__main__':
    data = [random.randint(0, 100) for i in range(10)]

    data.sort()
    #data = sorted(data)
    print(data)
    target = int(input('what number would you like to find? '))

    found = binary_search(data, target, 0, len(data) - 1)
    
    print(found)