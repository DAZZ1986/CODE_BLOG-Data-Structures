using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._Двусвязный_и_кольцевой_список__linked_list_.Model
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }



        public DuplexLinkedList() //конструктор
        {
        }
        public DuplexLinkedList(T data) //конструктор
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }



        public void Add(T data) //Что происходит когда мы хотим добавить второй эл. в двусвязный список, комментарий в файле Program, плюс
        {                        //картинка "Добавление второго эл. в двусвязный список". 
            var item = new DuplexItem<T>(data);

            if (Count == 0) //проверка если голова и хвост равны null
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }



        public void Delete(T data) //удаление эл.
        {
            var current = Head; //current - это по сути эл. который бегает по всему списку начиная с головы.
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
        }



        public DuplexLinkedList<T> Reverse() // метод реверса
        {
            var result = new DuplexLinkedList<T>(); //создаем дупле5кс лист

            var current = Tail; //и теперь мы начинаем добавлять с хвоста
            while (current != null) 
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;
        }



        public IEnumerator GetEnumerator() //это для использования foreach
        {
            var current = Head;
            while (current != null)
            {
                yield return current;   //по сути позволяет возвращать коллекцию - он просто берет и перебирает все эл. последовательности
                                        //возвращая их одну за другой и в результате на выходе у нас целая коллекция. (это синтаксич. сахар
                                        //равносильно если бы мы в ручную написали метод который бы перебирал все эл. и добавлял их по
                                        //очереди в список и на выходе вернул бы нам этот список)
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }







    }
}
