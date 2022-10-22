def divide_elementos_de_lista(lista, divisor):
    try:
        return [i / divisor for i in lista]
    except ZeroDivisionError as e:
        print(e)
        divisor = int(input('Ingresa un divisor diferente cero: '))
        return divide_elementos_de_lista(lista, divisor)


lista = list(range(10))
divisor = 0

print(divide_elementos_de_lista(lista, divisor))
