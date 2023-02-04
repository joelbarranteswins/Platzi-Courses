import random
import math

from matplotlib import pyplot as plt


def media(X: list):
    return sum(X) / len(X)


def varianza(X):
    mu = media(X)

    acumulador = 0
    for x in X:
        acumulador += (x - mu)**2

    return acumulador / len(X)


def desviacion_estandar(X):
    return math.sqrt(varianza(X))


def plot(X):
    # plot list using matplotlib scatter
    fig, ax = plt.subplots()
    ax.scatter(range(1, len(X) + 1), X, color='red', marker='.',
               label='Datos', s=30, alpha=0.5)
    ax.plot([1, len(X)], [media(X), media(X)], color='red',
            label='Media', linewidth=1, alpha=0.5)

    ax.plot(
        [1, len(X)],
        [media(X) + desviacion_estandar(X), media(X) + desviacion_estandar(X)], color='blue',
        label='Desviacion estandar', linewidth=2, alpha=1, linestyle='--')

    ax.plot(
        [1, len(X)],
        [media(X) - desviacion_estandar(X), media(X) - desviacion_estandar(X)], color='blue',
        linewidth=2, alpha=1, linestyle='--', label='Desviacion estandar')

    ax.set_title('Datos')
    ax.set_xlim(5, len(X) + len(X)/5)
    ax.set_ylim(5, max(X) + media(X)/5)
    ax.legend(loc='lower right')
    plt.show()


if __name__ == '__main__':
    X = [random.randint(9, 12) for i in range(20)]
    mu = media(X)
    Var = varianza(X)
    sigma = desviacion_estandar(X)

    plot(X)

    print(f'Arreglo X: {X}')
    print(f'Media = {mu}')
    print(f'Varianza = {Var}')
    print(f'Desviacion estandar = {sigma}')
