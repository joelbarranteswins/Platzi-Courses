rom datetime import datetime;


words_list = [];


def get_file(address):
  try:
    with open(address, "r", encoding="utf-8") as file:
      return True;
  except FileNotFoundError:
    return False;
  except IOError:
    return False;

def save_file(address):
  file_local = get_file(address);
  action = "w";

  if (file_local):
    action = input("Este archivo ya existe, quieres sobreescribirlo o agregarle estas nuevas notas?(a/w) ");
    if (not action):
      save_file(address);

  with open(address, action, encoding="utf-8") as file:
    for word in words_list:
      file.write(word);
    print("Guardado exitosamente");


def want_save_def():
  try:
    want_save = str(input("Quieres guardar estas notas?(si/no) ").lower());

    if want_save == "si":
      address = input("Donde quieres guardar el archivo? ");
      save_file(address);
    elif want_save != "si" and want_save != "no":
      raise ValueError();
  except ValueError:
    want_save_def();


def addNewWord(words_list, new_response):
  words_list.append(new_response + "\n");


def welcome(func):
  def wrapper(*args, **kwargs):
    func_result: str = func(*args, **kwargs);
    if func_result:
      print("""
  @@@   @@@   @@@@@
  @@@   @@@    @@@
  @@@@@@@@@    @@@
  @@@@@@@@@    @@@
  @@@   @@@   @@@@@
      """);
      print("welcome back 👋", func_result.upper(), "to your favorite notebook, (escribe lo que tengas en mente)");
  return wrapper;


def writeDate(my_func):
  def wrapper(moreExactly):
    date = datetime.now().date().strftime("%d/%m/%Y");
    if (moreExactly):
      date = datetime.now().strftime("%d/%m/%Y - %Hh:%Mm:%Ss");
    my_func(lambda: f"Fecha de la publicación: {date}");
  return wrapper;


@writeDate
def printNow(date):
  print(date());


@welcome
def sayWelcomeYourName():
  your_name = input("Enter your name please: ");

  assert type(your_name) == str, "Your name is and must be a string type";
  return your_name;


def main():
  sayWelcomeYourName();
  printNow(False);
  print("""
  """);
  while True:
    new_response = input("");

    if (new_response == "gnbye"):
      print("Ok, goodbye 👋");
      print(words_list);
      break;

    if (new_response == "gnsave"):
      want_save_def();
      break;

    addNewWord(words_list, new_response);


if __name__ == "__main__":
  main();