def aplicar_operaciones(num):
    operaciones = [abs, float]

    resultado = []
    for operacion in operaciones:
        resultado.append(operacion(num))

    return resultado


if __name__ == '__main__':
    valor = aplicar_operaciones(-2)
    print(valor)
