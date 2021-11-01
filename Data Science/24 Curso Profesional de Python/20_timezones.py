from datetime import datetime
import pytz

bogota_timezone = pytz.timezone("America/Bogota")
bogota_date = datetime.now(bogota_timezone)
print("Bogota: ", bogota_date.strftime("%d/%m/%Y, %H:%M:%S"))

def country_date(continent: str, country: str) -> str:
    continent = continent.lower().capitalize()
    country = country.lower().capitalize()

    country_timezone = pytz.timezone(f"{continent}/{country}")
    date = datetime.now(country_timezone)
    print(f"{country}: ", date.strftime("%d/%m/%Y, %H:%M:%S"))

# country_date(continent='america', country='peru')

bogota_timezone = pytz.timezone("America/Mexico_City")
bogota_date = datetime.now(bogota_timezone)
print("Mexico: ", bogota_date.strftime("%d/%m/%Y, %H:%M:%S"))

bogota_timezone = pytz.timezone("America/Caracas")
bogota_date = datetime.now(bogota_timezone)
print("Caracas: ", bogota_date.strftime("%d/%m/%Y, %H:%M:%S"))