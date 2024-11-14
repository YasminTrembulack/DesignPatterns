# Sujeito (Subject)
class EstacaoMeteorologica:
    def __init__(self):
        self._observadores = []
        self._temperatura = 0

    def registrar(self, observador):
        self._observadores.append(observador)

    def desregistrar(self, observador):
        self._observadores.remove(observador)

    def notificar(self):
        for observador in self._observadores:
            observador.atualizar(self._temperatura)

    def definir_temperatura(self, temperatura):
        self._temperatura = temperatura
        self.notificar()  # Notifica todos os observadores

# Observador
class DisplayTemperatura:
    def atualizar(self, temperatura):
        print(f"Temperatura atual: {temperatura}°C")

# Exemplo de uso do Observer
estacao = EstacaoMeteorologica()
display = DisplayTemperatura()

# Registrando o observador
estacao.registrar(display)

# Mudando o estado do sujeito (EstacaoMeteorologica)
estacao.definir_temperatura(25)
estacao.definir_temperatura(30)
