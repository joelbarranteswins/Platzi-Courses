def enumeracion_exhaustiva(objetivo):
    respuesta = 0

    while respuesta**2 < objetivo:
        respuesta += 1

    if respuesta**2 == objetivo:
        print(f'La raiz de {objetivo} es {respuesta}')
    else:
        print(f'{objetivo} no tiene raiz cuadrada exacta')


def aproximacion(objetivo, epsilon):
    paso = epsilon**2
    respuesta = 0.0
    iteraciones = 0

    while abs(respuesta**2 - objetivo) >= epsilon and respuesta <= objetivo:
        respuesta += paso
        iteraciones += 1

    if abs(respuesta**2 - objetivo) >= epsilon:
        print(f'No se encontro raiz cuadrada {objetivo}')
    else:
        print(f'La raiz cuadrada de {objetivo} es {respuesta}')


def busqueda_binaria(objetivo, epsilon):
    bajo = 0.0
    alto = max(1.0, objetivo)
    respuesta = (alto + bajo) / 2

    # absoluto = abs(respuesta**2 - objetivo)
    # print(f'absoluto: {absoluto}')

    while abs(respuesta**2 - objetivo) >= epsilon:
        print(f'bajo={bajo}, alto={alto}, respuesta={respuesta}')
        if respuesta**2 < objetivo:
            bajo = respuesta
        else:
            alto = respuesta
        respuesta = (alto + bajo) / 2

        print(f'La raiz cuadrada de {objetivo} es {respuesta}')


if __name__ == '__main__':
    opcion = int(input(f'Elija el algoritmo de ordenamiento para buscar la raiz cuadrada de su numero \n 1. Enumeracion Exhaustiva \n 2. Aproximacion \n 3. Busqueda Binaria \n'))

    if opcion == 1:
        print('1. Enumeracion Exhaustiva')
        numero = int(input('* Digite un numero: '))
        enumeracion_exhaustiva(numero)
    elif opcion == 2:
        print('2. Aproximacion')
        numero = int(input('* Digite un numero: '))
        parametro_epsilon = float(input('* Digite un epsilon: '))
        aproximacion(numero, parametro_epsilon)
    elif opcion == 3:
        print('3. Busqueda Binaria')
        numero = int(input('* Digite un numero: '))
        parametro_epsilon = float(input('* Digite un epsilon: '))
        busqueda_binaria(numero, parametro_epsilon)
    else:
        print('Opcion no valida')
