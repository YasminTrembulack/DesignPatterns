using System;
using System.Collections;

namespace SimpleIteratorExample
{
    // Implementação de um Iterator simples
    public class SimpleIterator : IEnumerator
    {
        private readonly string[] _items;
        private int _position = -1;

        // Construtor para inicializar os itens
        public SimpleIterator(string[] items)
        {
            _items = items;
        }

        // Move para o próximo elemento
        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        // Reseta a posição
        public void Reset()
        {
            _position = -1;
        }

        // Obtém o item atual
        public object Current
        {
            get
            {
                if (_position < 0 || _position >= _items.Length)
                    throw new InvalidOperationException();
                return _items[_position];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma coleção de itens
            string[] items = { "Apple", "Banana", "Cherry" };

            // Instanciando o Iterator
            SimpleIterator iterator = new SimpleIterator(items);

            Console.WriteLine("Iterando sobre a coleção:");
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
