
from typing import Union
from people import Drunker, Addicted
from field import Field
from coordinate import Coordinate


def main(
        steps_list: list[int],
        tries: int,
        people: Union[Drunker, Addicted]) -> None:

    distances_mean_list: list[float] = []
    coordinates_list: list[list[Coordinate]] = []

    for steps in steps_list:
        distances, coordinates = Field.simulate_tries_and_get_distances(
            steps=steps, tries=tries, people=people)
        mean, maximun, minimum = Field.get_results(
            people=people, steps=steps, distances=distances)
        distances_mean_list.append(mean)
        coordinates_list.append(coordinates)

        print(f""" 
        {people.name} caminata aleatoria de {steps} pasos
        \nMedia = {mean}
        \nMax = {maximun}
        \nMin = {minimum}""")

    Field.plot(x=steps_list, y=distances_mean_list,
               coordinates_list=coordinates_list)


if __name__ == '__main__':
    steps: list[int] = [10000]
    tries: int = 100
    people: Union[Drunker, Addicted] = Addicted(name='Juan')

    main(steps_list=steps, tries=tries, people=people)
