using System;

namespace _4._Очередь__Дек__Queue__Deque_.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }



        public Item(T data)
        {
            Data = data;
        }



        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
