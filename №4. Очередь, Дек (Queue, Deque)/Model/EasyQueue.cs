using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Очередь__Дек__Queue__Deque_.Model
{
    public class EasyQueue<T>
    {
        private List<T> items = new List<T>(); // наш список
        private T Head => items.Last(); //Голова. мы можем сделать закрытые свойства для более удобного доступа к эл. нашего внутреннего
                                        //списка, чтобы в коде их использовать. Сокращенная запись, что то типа присвоения.
        private T Tail => items.First(); //Хвост.
        public int Count => items.Count;  //это свойство геттер вроде


        public EasyQueue() //конструктор
        {
        }
        public EasyQueue(T data) //тут нужно делать проверку, когда мы хотим что то засовывать из публичных методов.
        {
            items.Add(data);
        }


        public void Enqueue(T data) //делаем добавление
        {
            items.Insert(0, data); //первый параметр это индекс позиции эл. в списке, второй параметр сами данные
        }

        public T Dequeue() //извлечение эл. из очереди
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek() //операция посмотреть головной эл.(Head)
        {
            return Head;
        }








    }
}
