using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Стек__stack_.Models
{
    public class EasyStack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        //тут мы делаем обертку над списком


        //далее основные операции которые нам нужны для списка

        public int Count => items.Count;  //современный вариант написания 1, это просто как свойство get.
        public int Count2()               //классический вариант написания 2, это развернутый get, тоесть метод.
        {
            return items.Count;
        }

        public bool IsEmpty => items.Count == 0;    // это свойство которое возвращает false если List пуст.


        public void Push(T item) //заталкивать
        {
            items.Add(item);
        }


        public T Pop() //вытаскиваем
        {
            if (!IsEmpty) //проверяем через свойство не пуст ли наш List
            {
                var item = items.LastOrDefault();
                items.Remove(item); //тк это Pop, а не Peek, его следует еще и удалять
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }


        public T Peek() //смотрим на эл. сверху и не удаляем его из коллекции
        {
            if (!IsEmpty) //проверяем через свойство не пуст ли наш List
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }



        public void Clear() //проброс метода для очистки
        {
            items.Clear();
        }



        public object Clone() //клонировали список и в памяти они будут разнесены. Реализуем метод интерйеса ICloneable
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }




        public override string ToString()
        {
            return $"Steck s {Count} elementami.";
        }


    }
}
