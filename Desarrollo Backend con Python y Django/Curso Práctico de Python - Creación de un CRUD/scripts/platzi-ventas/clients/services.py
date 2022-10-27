from clients.models import Client
from common.services import PVService


class ClientService(PVService):

    def __init__(self, table_name):
        super().__init__(table_name)

    def create_client(self, client):
        self.create(client.to_dict(), Client.schema())

    def list_clients(self):
        return self.list(Client.schema())

    def update_client(self, updated_client):
        self.update(updated_client.to_dict(), Client.schema())

    def delete_client(self, client_uid):
        self.delete(client_uid, Client.schema())

