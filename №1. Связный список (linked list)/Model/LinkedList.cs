using System;
using System.Collections;

namespace _1_Связный_список__linked_list_.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable //наш список будет типизированный
    {
        // Первый элемент спика, голова(Head) - это первый элемент от которого начинается отсчет и есть Хвост(Tail) - это последний
        // элемент, а все эл. посередине будут между головой и хвостом. Тоесть голова всегда первый эл., в хвост всегда последний эл.
        public Item<T> Head { get; private set; } //это голова. тоесть мы сможем при необходимость посмотреть какой эл. является
                                                  //головным и так же из вне не даем возможности в него, что то писать.
        // Последний элемент списка.
        public Item<T> Tail { get; private set; }   // это хвост

        // Кол-во эл. в списке.
        public int Count { get; private set; }      // делаем подсчет кол-ва элементов.




        // Создать пустой список.
        public LinkedList() //конструктор
        {
            Clear();
        }


        // Создать список с начальным элементом.
        public LinkedList(T data)   //конструктор перегруженный, для моментального добавления данных
        {
            SetHeadandTail(data);
        }




        // операция - данных в конец списка.
        public void Add(T data)
        {
            //теперь нам нужно прицепить этот новый эл. к существующему, для этого нужно проверить если ли в списке что то, тк мы всегда
            //добавляем в конец, соответственно проверяем есть ли что в Хвосте
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item; //по сути мы взяли и зацепили указатель хвостового элемента за следующий
                Tail = item; //и теперь нам нужно сделать хвост этим элементом, тоесть теперь указатель на крайний эл. перескакивает
                             //на следующий, тоесть на новый созданный эл., короче в хвосту присвоили новый эл.
                Count ++;   //добавили счетчик эл. в списке
            }
            else
            {
                SetHeadandTail(data); //а если у нас нет хвоста, то устанавливаем его
            }
        }




        // операция добавления эл. в начало списка
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }



        // операция вставки эл. после элемента. Ищем совпадение таргета, создаем новый эл., меняем указатель с предыдущего эл. на новый
        // и с нового на след. эл.
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target)) //если совпадет с таргетом то вставляем после таргета
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else //а тут если Head равен нулю
            {
                // Нужно решить, если список пустой то либо не добавляем ничего, либо добавляем 2 эл.
            }
        }




        // операция - удаления первого вхождение данных в список
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data)) //если совпадет первый элемент
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                //далее если эл. не первый
                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else //а если Head равен нулю
            {
                SetHeadandTail(data);
            }
        }





        //метод полной очистки списка
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }



        //метод установки головы и хвоста
        private void SetHeadandTail(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }




        //Получить перечисление всех элементов списка. Реализация интерфейса нужна для того, чтобы наш список можно было выводить при
        //помощи foreach.
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data; //Оператор yield return используется для возврата каждого элемента по одному.
                                           //Использование в операторе контекстного ключевого слова yield означает, что метод, оператор
                                           //или метод доступа get, в котором присутствует это ключевое слово, является итератором.
                current = current.Next;
            }
        }



        public override string ToString()
        {
            return "Linked List" + Count + " элементов.";
        }



    }
}
