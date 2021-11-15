using System;

namespace _2._Стек__stack_.Models
{
    public class ArrayStack<T>
    {
        T[] items; 
        private int current = -1;   //для того чтобы удостовериться что стек не пустой
        private readonly int size = 10;
        public int MaxCount => items.Length; //максимальное кол-во эл. в массиве
        public int Count => current + 1;  //кол-во эл. в массиве.


        public ArrayStack(int size = 10) //int size = 10 - это аргумент по умолчанию(их всега писать в конце если у нас есть обязательные
                                         //параметры). Задем размер нашего стека/массива.
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size) //обращаемся к базовому конструктору и передаем в него size -  : this(size)
        {
            items[0] = data;
            current = 1;
        }


        public void Push(T data)
        {
            if (current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else 
            {
                throw new StackOverflowException("Stack overflow");
            }
        }


        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }


        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }










    }
}
