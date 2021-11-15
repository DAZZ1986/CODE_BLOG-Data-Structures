using System;


namespace _4._Очередь__Дек__Queue__Deque_.Model
{
    class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Next { get; set; }
        public DuplexItem<T> Previous { get; set; }


        public DuplexItem(T data)
        {
            Data = data;
        }



        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
