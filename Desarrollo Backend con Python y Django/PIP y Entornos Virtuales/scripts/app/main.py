import utils
import read_csv
import charts
import pandas as pd
from pathlib import Path


def run():
    '''
    data = list(filter(lambda item : item['Continent'] == 'South America',data))
    countries = list(map(lambda x: x['Country'], data))
    percentages = list(map(lambda x: x['World Population Percentage'], data))
    '''

    # get working directory with Path
    working_directory = Path(__file__).parent

    file_path = Path.joinpath(working_directory, 'data', 'countries.csv')

    df = pd.read_csv(file_path)
    df = df[df['Continent'] == 'Africa']

    countries = df['Country'].values
    percentages = df['World Population Percentage'].values
    charts.generate_pie_chart(countries, percentages)

    data = read_csv.read_csv(file_path)
    country = input('Type Country => ')
    print(country)

    result = utils.population_by_country(data, country)

    if len(result) > 0:
        country = result[0]
        print(country)
        labels, values = utils.get_population(country)
        charts.generate_bar_chart(country['Country'], labels, values)


if __name__ == '__main__':
    run()
