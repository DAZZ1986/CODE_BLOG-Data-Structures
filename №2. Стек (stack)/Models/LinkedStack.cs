using System;

namespace _2._Стек__stack_.Models
{
    public class LinkedStack<T>
    {
        public Item<T> Head { get; set; }
        public int Count { get; set; }



        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            Head = new Item<T>(data);
            Count = 1;
        }




        public void Push(T data)    //тут всегда добавляем в начало списка
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (Count > 0)//проверка на пустоту
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else 
            {
                throw new NullReferenceException("Stack is empty");
            }
        }


        


    }
}
