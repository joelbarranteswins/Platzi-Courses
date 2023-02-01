import sys


def fibonacci_recursivo(n):
    if n == 0 or n == 1:
        return 1
    return fibonacci_recursivo(n - 1) + fibonacci_recursivo(n - 2)


def fibonacci_dinamico_start(n):
    result = fibonacci_dinamico(n-1)
    return result


def fibonacci_dinamico(n, nemo={}):
    if n == 0 or n == 1:
        return 1
    try:
        return nemo[n]
    except KeyError:
        resultado = fibonacci_dinamico(
            n - 1, nemo) + fibonacci_dinamico(n - 2, nemo)
        nemo[n] = resultado

        return resultado


def fibonacci(num):
    arr = [0, 1]
    if num == 1:
        print(['0'])
    elif num == 2:
        print('[0,', '1]')
    else:
        while (len(arr) < num):
            arr.append(0)
        if (num == 0 or num == 1):
            return 1
        else:
            arr[0] = 0
            arr[1] = 1
            for i in range(2, num):
                arr[i] = arr[i-1]+arr[i-2]
            print(arr)


if __name__ == '__main__':
    # sys.setrecursionlimit(10002)
    print(fibonacci_dinamico_start(4))

    fibonacci(4)
