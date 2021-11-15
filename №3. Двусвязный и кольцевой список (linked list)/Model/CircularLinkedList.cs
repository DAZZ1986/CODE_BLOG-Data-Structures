using System;
using System.Collections;

namespace _3._Двусвязный_и_кольцевой_список__linked_list_.Model
{
    public class CircularLinkedList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public int Count { get; set; }

        public CircularLinkedList() //конструктор
        {
        }
        public CircularLinkedList(T data) //конструктор
        {
            SetHeadItem(data);
        }


        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;      //делаем кольцевым
            Head.Previous = Head;  //делаем кольцевым
            Count = 1;
        }


        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }
            //когда эл. новый
            var item = new DuplexItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }



        public void Delete(T data) //удаление нужно делать заданное кол-во раз, чтобы он не бегал по кругу, для этого используем счетчик.
        {
            if (Head.Data.Equals(data)) //сравниваем данные с Головой, если совпадают то ...
            {
                RemovetemI(Head); // то... удаляем этот эл.
                Head = Head.Next; // а указатель головы устанавливаем на следующий эл.
                return;
            }

            var current = Head.Next; //если первый эл. не равен то переходим к следующему
            for (int i = Count; i > 0; i--) //в цикле ищем по кругу эл.
            {
                if (current != null && current.Data.Equals(data)) // как эл. будет найден
                {
                    RemovetemI(current);  // удаляем его
                }
                current = current.Next;
            }
        }

        private void RemovetemI(DuplexItem<T> current)
        {
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
        }




        public IEnumerator GetEnumerator()
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }





    }
}
