# Model: Contém os dados
class TodoModel:
    def __init__(self):
        self.todos = []

    def add_task(self, task):
        self.todos.append(task)

    def get_tasks(self):
        return self.todos

# View: Responsável por exibir os dados
class TodoView:
    def display_tasks(self, tasks):
        print("Tarefas:")
        for task in tasks:
            print(f"- {task}")

# Controller: Responsável por coordenar a interação entre Model e View
class TodoController:
    def __init__(self, model, view):
        self.model = model
        self.view = view

    def add_task(self, task):
        self.model.add_task(task)

    def show_tasks(self):
        tasks = self.model.get_tasks()
        self.view.display_tasks(tasks)

# Usando o MVC
model = TodoModel()
view = TodoView()
controller = TodoController(model, view)

controller.add_task("Comprar leite")
controller.add_task("Estudar Python")
controller.show_tasks()
