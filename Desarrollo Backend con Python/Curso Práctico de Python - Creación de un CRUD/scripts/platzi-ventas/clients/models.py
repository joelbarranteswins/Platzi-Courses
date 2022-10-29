from common.models import PVClient


class Client(PVClient):

    def __init__(self, name, company, email, position, uid=None):
        super().__init__(uid)
        self.name = name
        self.company = company
        self.email = email
        self.position = position

    @staticmethod
    def schema():
        return ['name', 'company', 'email', 'position', 'uid']

