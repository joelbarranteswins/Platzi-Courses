from typing import Union
from people import Drunker, Addicted
from coordinate import Coordinate
from typing import Union
from bokeh.plotting import figure, show
from bokeh.layouts import row, column, gridplot


class Field:

    def __init__(self):
        self.initial: Coordinate = Coordinate(0, 0)
        self.position: Coordinate = Coordinate(0, 0)
        self.coordinates: list[Coordinate] = [self.position]

    def get_distance(
            self,
            initial_coordinate: Coordinate,
            final_coordinate: Coordinate) -> float:
        length_x = initial_coordinate.x - final_coordinate.x
        length_y = initial_coordinate.y - final_coordinate.y

        return (length_x**2 + length_y**2)**0.5

    def move_and_coordinates_list(
            self,
            people: Union[Drunker, Addicted],
            steps: int) -> tuple[Coordinate, list[Coordinate]]:
        for _ in range(steps):
            length_x, length_y = people.walk()
            self.position = self.position.move(length_x, length_y)
            self.coordinates.append(self.position)
        return self.position, self.coordinates

    @staticmethod
    def simulate_tries_and_get_distances(
            steps: int,
            tries: int,
            people: Union[Drunker, Addicted]) -> tuple[list[float], list[Coordinate]]:
        distances: list[float] = []
        coordinates_list: list[list[Coordinate]] = []

        for _ in range(tries):
            field = Field()
            position, coordinates = field.move_and_coordinates_list(
                people=people, steps=steps)
            distance: float = field.get_distance(field.initial, position)
            distances.append(distance)
            coordinates_list.append(coordinates)
        return distances, coordinates_list[-1]

    @staticmethod
    def get_results(
            people: Union[Drunker, Addicted],
            steps: int,
            distances: list[float]) -> tuple:
        mean = round(sum(distances) / len(distances), 4)
        maximun = max(distances)
        minimum = min(distances)

        return mean, maximun, minimum

    @staticmethod
    def plot(
            x: list[int],
            y: list[float],
            coordinates_list: list[list[Coordinate]]) -> None:
        figure_1 = figure(title="Camino aleatorio",
                          x_axis_label="x", y_axis_label="y")
        figure_1.line(x, y, legend_label="distancia media", line_width=2)

        figure_2 = figure(title="Camino aleatorio",
                          x_axis_label="x", y_axis_label="y")

        for coordinates in coordinates_list:
            x = [coordinate.x for coordinate in coordinates]
            y = [coordinate.y for coordinate in coordinates]
            figure_2.line(x, y, line_width=2)

        # show the results
        show(column(figure_1, figure_2))
