from abc import ABC, abstractmethod

class CoffeePreparation(ABC):
    def prepare_coffee(self):
        self.boil_water()
        self.brew()
        self.pour_in_cup()
        self.add_condiments()
    
    def boil_water(self):
        print("Fervendo a água...")
    
    def pour_in_cup(self):
        print("Colocando o café na xícara...")

    @abstractmethod        
    def brew(self):
        pass
    
    @abstractmethod 
    def add_condiments(self):
        pass
    
class BlackCoffee(CoffeePreparation):
    def brew(self):
        print("Passando o café preto...")
        
    def add_condiments(self):
        print("Sem adição de condimentos.")
        
class MilkCoffee(CoffeePreparation):
    def brew(self):
        print("Passando o café preto...")
        
    def add_condiments(self):
        print("Adicionando leite e açucar...")
        
print("Preparando Café Preto:")
black_coffee = BlackCoffee()
black_coffee.prepare_coffee()

print("Preparando Café com Leite:")
milk_coffee = MilkCoffee()
milk_coffee.prepare_coffee()



