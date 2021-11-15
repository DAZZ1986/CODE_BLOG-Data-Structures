using System;

namespace _3._Двусвязный_и_кольцевой_список__linked_list_.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Previous { get; set; }
        public DuplexItem<T> Next { get; set; }



        public DuplexItem(T data) //конструктор
        {
            Data = data;
        }


        public override string ToString()
        {
            return Data.ToString();
        }







    }
}
