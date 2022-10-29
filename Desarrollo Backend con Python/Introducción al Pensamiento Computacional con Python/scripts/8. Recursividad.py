def factorial(n):
    """Calcula el factorial de n

    n int > 0
    return n!
    """
    print(n)
    # Para que la recursividad no sea infinita
    # definimos en que momento terminara.
    if n == 1:
        return 1

    # Llamamos a la función "factorial" a si misma
    # pero el valor de n va disminuyendo en 1
    # a medida que se repite su llamado.
    return n * factorial(n - 1)


if __name__ == '__main__':
    n = int(input('Escribe un entero: '))
    print(factorial(n))
