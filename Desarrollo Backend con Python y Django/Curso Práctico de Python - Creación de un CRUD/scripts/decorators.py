PASSWORD = '1234'

def upper(func):
    def wrapper(*args, **kwargs):
        result = func(*args, **kwargs)
        return result.upper()

    return wrapper


def password_required(func):
    def wrapper():
        password = input('What is the password? ')

        if password == PASSWORD:
            return func()
        else:
            print('invalid password!!!')

    return wrapper


@password_required
def needs_password():
    print('The password is correct')


@upper
def say_name(name):
    return 'Hello, {}'.format(name)


if __name__ == '__main__':

    needs_password()
