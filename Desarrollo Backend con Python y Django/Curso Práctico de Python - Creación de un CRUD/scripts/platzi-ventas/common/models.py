import abc
import uuid


class PVClient(abc.ABC):
    
    def __init__(self, uid=None):
        self.uid = uid or uuid.uuid4()

    def to_dict(self):
        return vars(self)

    @staticmethod
    @abc.abstractmethod
    def schema():
        pass
