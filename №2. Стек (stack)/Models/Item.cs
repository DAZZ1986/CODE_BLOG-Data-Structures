using System;

namespace _2._Стек__stack_.Models
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Previous { get; set; }
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
