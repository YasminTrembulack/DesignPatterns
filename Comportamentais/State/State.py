import time

# Função para contagem regressiva
def contagem_regressiva(tempo):
    for i in range(tempo, 0, -1):
        print(f"Tempo restante: {i} segundos")
        time.sleep(1)
    print("Fim da contagem regressiva!")

#Chama a função com 10 segundos
contagem_regressiva(10)



