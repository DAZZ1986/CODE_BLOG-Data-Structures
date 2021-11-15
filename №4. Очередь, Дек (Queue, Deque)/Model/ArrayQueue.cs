using System;
using System.Linq;

namespace _4._Очередь__Дек__Queue__Deque_.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;  //наш массив
        private T Head => items[Count > 0 ? Count - 1: 0];
        private T Tail => items[0]; //это гет под сахаром. Хвост.
        private int MaxCount => items.Length;
        public int Count { get; private set; }  //это длина массива


        public ArrayQueue(int size) //конструктор
        {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data) //тут нужно делать проверку, когда мы хотим что то засовывать из публичных методов.
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }


        public void Enqueue(T data) //делаем добавление - Для добавления эл. - мы берем и объединяем эл. и существующий массив, соединяем их
                                    //и каледм обратно в items если кол-во не превышает. Создаем переменную для замера кол-ва MaxCount.
        {
            // ниже реализация покороче, но не факт что будет работать быстрее.
            if (Count < MaxCount)//
            {
                var result = (new T[] { data }).Concat(items);
                items = result.ToArray();
                Count++;
            }

            // ниже реализация низкого уровня программиста.
            //if (Count < MaxCount)//нужно проверять кол-во эл. в массиве чтобы не было переполнения, тк массив ограничен по кол-ву эл.
            //{
            //    T[] result = new T[MaxCount]; //создали массив с кол-во эл. равным MaxCount
            //    result[0] = data;  //положили data в [0] индекс массива
            //    for (int i = 0; i < Count; i++)
            //    {
            //        result[i + 1] = items[i];  //добавили последовательно все эл. массива с индекса [1]
            //    }

            //    items = result;
            //    Count++;
            //}
        }

        public T Dequeue() //извлечение эл. из очереди - тут мы посути просто перемещаем указатель
        {
            var item = Head;
            Count--;
            return item;
        }

        public T Peek() //операция посмотреть головной эл.(Head)
        {
            return Head;
        }









    }
}
