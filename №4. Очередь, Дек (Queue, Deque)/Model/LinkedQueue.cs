using System;

namespace _4._Очередь__Дек__Queue__Deque_.Model
{
    class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; set; }


        public LinkedQueue() //конструктор
        {
        }
        public LinkedQueue(T data) //тут нужно делать проверку, когда мы хотим что то засовывать из публичных методов.
        {
            SetHeadItem(data);
        }


        public void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }



        public void Enqueue(T data) //делаем добавление
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;
        }



        public T Dequeue() //извлечение эл. из очереди
        {
            var data = head.Data;
            var current = tail.Next;
            var previous = tail;
            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;
            return data;
        }


        public T Peek() //операция посмотреть головной эл.(Head)
        {
            return head.Data;
        }





    }
}
