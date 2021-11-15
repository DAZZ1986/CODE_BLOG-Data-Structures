using _4._Очередь__Дек__Queue__Deque_.Model;
using System;
using System.Collections.Generic;

namespace _4._Очередь__Дек__Queue__Deque_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Очередь, Дек (Queue, Deque) - Структуры данных C#
            /*
            //////////////////
            Очередь(Queue) односторонняя очередь - работает по принципу FIFO(first in, first out - первый пришел, первй ушел). 
            Более логичная очередь, когда мы приходим и занимаем очередь в конце. Тоесть добавляем в Tail, и выходим из очереди из Head, а
            доступ к средним эл. и к Tail мы не имеем, только можем извлечь или посмотреть, что лежит в Head.

            Операция постановки в очередь с хвоста(Tail):
            Push - так редко называют, чаще называют след. команду Enqueue.
            Enqueue - это операция добавления эл. в очередь.

            Операция выхода из очереди осуществляется с головы(Head):
            Pop - операция по выходу из очереди, но тоже так лучше не надо называть, а лучше называть dequeue.
            Dequeue - выход из очереди, извлечение эл. из очереди.

            Peek - операция посмотреть головной эл.(Head), тоесть не извлекая эл. просто посмотреть что лежит в Head. Так же еще эту команду
            называют, top, но лучше использовать peek.


            Виды реализации:
            1.List<T> - Сегодня на практике мы будем использовать обычный List<T> над которым сделаем обертку, которая запрещает доступ к 
            средним эл. Или наверное на осноове List<T> мы делать не будет тк у нее нет ограничения по кол-ву эл. и она может разростатться
            слишком большой. 
            2.Array - мы можем реализовать нашу очередь на основе массива. Преимущество в том, что мы делаем список ограниченным по кол-ву эл. 
            Если будет приходить в очередь эл. который за пределами ограничения, тоесть не помещаться то будет выдавать сообщение об ошибке. 
            3.LinkedList - И конечно мы сможем реализовать нашу очередь на основне связного списка LinkedList.

            Queue<T> - а вообще в работе не нужно самому реализовывать очередь, а нужно использовать стандартную готовую структуру данных, 
            которая называется Queue<T>, она является Generic. 






            //////////////////
            Дек(Deque) двусторонняя очередь - отличается тем, что, мы можем добавлять и извлекать эл. сразу с двух концов, как в Head, так и
            в Tail.  Расширение очереди будет происходить в виде добавления эл. с головы и/или с хвоста.
            
            Операции можно называть как:
            Tail
            Pushback - это постановка в хвост.
            Popback  - это извлечение из хвоста.
            Head
            Pushfront - это постановка в хвост.
            Popfront  - это извлечение из хвоста.

            Peekback  - операция просмотра Tail без извлечения.
            Peekfront - операция просмотра Head без извлечения.


            Виды реализации:
            1.List<T> - можем на основе листа.
            2.Array - можем на основе массива.
            3.LinkedList - логичнее всего реализовать на двусвязном списке.


            ////////////////////////////////////////////////////
            Это просто наработочки, свойства под сахаром
            private T[] items;  //наш массив

            private T Tail => items[0];                       //гет - под сахаром. эквивалентные записи 
            private T Tail2 { get { return items[0]; } }      //гет - без сахара. эквивалентные записи 
            public int Count2 { get => items.Count; }         //гет - мало сахара. эквивалентные записи 

            private int count3;
            public int Count3 { set => count3 = value; }      //сет - мало сахара.
            ////////////////////////////////////////////////////
            */




            Console.WriteLine("Очередь(Queue) односторонняя очередь");

            Console.WriteLine("|||||||| ДАЛЕЕ Queue самая простая реализация - на основе листа List<T> (обернем список)");
            //создаем класс EasyQueue<T>, делаем его публичным и типизированным по шаблону.
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1); //первый эл. попадет в голову
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5); //последний эл. попадет в хвост как в обычной очереди

            //ниже все команды могут работать только с Head, в этом смысл очереди
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());   //все верно



            Console.WriteLine("|||||||| ДАЛЕЕ Queue реализация - на основе массива Array (обарачиваем массив)");
            //создаем класс ArrayQueue<T>, делаем его публичным и типизированным по шаблону.
            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(1); //первый эл. попадет в голову
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5); //последний эл. попадет в хвост как в обычной очереди

            //ниже все команды могут работать только с Head, в этом смысл очереди
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());   //все верно




            Console.WriteLine("|||||||| ДАЛЕЕ Queue реализация - на основе связного списка LinkedList (обарачиваем связный список)");
            //создаем класс LinkedQueue, и создаем класс Item.
            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1); //первый эл. попадет в голову
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5); //последний эл. попадет в хвост как в обычной очереди

            //ниже все команды могут работать только с Head, в этом смысл очереди
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());   //все верно








            Console.WriteLine("Дек(Deque) двусторонняя очередь");

            Console.WriteLine("|||||||| ДАЛЕЕ Deque реализация - на основе листа List<T> (обернем список)");
            //создаем класс EasyDeque<T>, делаем его публичным и типизированным по шаблону.
            var easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(600);
            easyDeque.PushBack(700);
            //засовываем и выдергиваем с разных сторон, а проталкиваем от краев к центру
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront()); //все верно


            Console.WriteLine("|||||||| ДАЛЕЕ Deque реализация - на основе двусвязного списка DuplexList (обарачиваем двусвязный список)");
            //создаем класс DuplexLinkedDeque<T> и DuplexItem<T>, делаем его публичным и типизированным по шаблону.
            var linkedDeque = new DuplexLinkedDeque<int>();
            linkedDeque.PushFront(1);
            linkedDeque.PushFront(2);
            linkedDeque.PushFront(3);
            linkedDeque.PushBack(40);
            linkedDeque.PushBack(50);
            linkedDeque.PushFront(600);
            linkedDeque.PushBack(700);
            //засовываем и выдергиваем с разных сторон, а проталкиваем от краев к центру
            Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopFront()); //все верно















        }
    }
}
