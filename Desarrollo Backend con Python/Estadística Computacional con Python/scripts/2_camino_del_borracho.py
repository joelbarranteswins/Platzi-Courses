import random
import seaborn as sns
import matplotlib.pyplot as plt


class Borracho:

    def __init__(self):
        self.posicion = [0, 0]

    def camino_borrachos(self, pasos: int):

        plt.scatter(x=self.posicion[0], y=self.posicion[1])

        direccion = random.choice(["derecha", "izquierda", "arriba", "abajo"])
        axis_x = [self.posicion[0]]
        axis_y = [self.posicion[1]]

        for i in range(pasos):

            direccion = random.choice(
                ["derecha", "izquierda", "arriba", "abajo"])
            if direccion == "izquierda":
                self.posicion[0] -= 1
            elif direccion == "derecha":
                self.posicion[0] += 1
            elif direccion == "arriba":
                self.posicion[1] += 1
            elif direccion == "abajo":
                self.posicion[1] -= 1
            else:
                return None

            axis_x.append(self.posicion[0])
            axis_y.append(self.posicion[1])

        plt.scatter(x=axis_x, y=axis_y, c="r",
                    alpha=0.3, s=5*len(axis_x), marker='.')
        plt.plot(axis_x, axis_y, c="b", alpha=0.5,
                 linewidth=1, linestyle="--")

        plt.show()

        return self.posicion


if __name__ == "__main__":
    borrachin = Borracho()
    direccion_final = borrachin.camino_borrachos(pasos=100)
    print(direccion_final)
    distancia_final = (direccion_final[0]**2+direccion_final[1]**2)**0.5
    print("La distancia final es: ", distancia_final)
