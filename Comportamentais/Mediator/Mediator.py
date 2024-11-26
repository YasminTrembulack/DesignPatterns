from abc import ABC, abstractmethod

#Medietor
class ChatMediator(ABC):
    @abstractmethod
    def send_message(self, message, user):
        pass
    
#Mediator Concreto
class ChatRoom(ChatMediator):
    def __init__(self):
        self.users = []
        
    def add_user(self, user):
        self.users.append(user)
        
    def send_message(self, message, user):
        for u in self.users:
            if u != user: 
                u.recive(message)
                        
class User:
    def __init__(self,name, chat_room):
        self.name = name
        self.chat = chat_room
        chat_room.add_user(self)
        
    def send(self, message):
        print(f"{self.name} envia: {message}")
    
    def recive(self, message):
        print(f"{self.name} recebeu: {message}")
    

#Codigo Cliente

chat_room =  ChatRoom()

user1 = User("Alice", chat_room)
user2 = User("Bob", chat_room)
user3 = User("Carol", chat_room)

user1.send("oi, pessoal!")
user2.send("Olá, Alice!")
user3.send("oi, Bob e Alice!")













