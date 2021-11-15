using _3._Двусвязный_и_кольцевой_список__linked_list_.Model;
using System;

namespace _3._Двусвязный_и_кольцевой_список__linked_list_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Двусвязный список и Двусвязный кольцевой список (linked list) - Структуры данных C#
            /*
            1. Односвязный список как мы помним состоит из ячеек, которые содержат в себе D(data-данные) и N(next-указатель на след. ячейку).
            Основной минус односвязного списка - это то, что движение возможно только в одну сторону. Тоесть если нам нужно к примеру
            сначала к 3 эл., потом ко 2 эл., потом к 1 эл., то каждый раз мы будем проходить от начала списка, тк мы не можем проходит
            в обратном направлении. И для решения это проблемыбыл созда двусвязный список.

            2. Двусвязный список - может проходить в обе стороны, как вперед так и назад и поэтому структура ячейки состоит из P(previous-это
            указатель на предыдущую ячейку), D(data-данные) и N(next-указатель на след. ячейку). И двусвязный список так же как и односвязный
            всегда имеет первую ячейку Head(голова) и последнюю ячейку Tail(хвост). В ячейках Head и Tail есть указатели на null в previous и
            next, говорящие о том, что он прерывается.

            Что происходит когда мы хотим добавить второй эл. в двусвязный список - см. картинку "Добавление второго эл. в двусвязный список".
            комментарий - когда у нас один эл. то Previous и Next указывают на null, но когда мы добавляем второй эл., то Next первого эл.
            должен уже указывать на Previous второго эл. чтобы они друг друга идели, а Previous первого и Next второго эл. будут указывать 
            на null, тк более ни спереди ни сзади у нас ячеек нет.

            3. Двусвязный кольцевой список - это когда у него нет в ячейках указателя на null, говорящий о том, что он прерывается, тк он 
            зациклен по кругу. И он имеет только ячейку Head, которая была добавлена в список первой, а Tail нет вообще, тк голова 
            одновременно и является хвостом. Так же кольцевой список может быть как односвязный, так и двусвязный. 
            */



            Console.WriteLine("||||||| ДАЛЕЕ создаем Двусвязный список");
            //ДАЛЕЕ создаем пример двусвязного списка, а именно класс itema и класс Lista - DuplexItem<T>, DuplexLinkedList<T>.
            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("вывод списка после удаления эл.");
            duplexList.Delete(3);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("||||||| ДАЛЕЕ добавляем метод реверса списка");
            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }





            Console.WriteLine("||||||| ДАЛЕЕ создаем Двусвязный кольцевой список");
            // Для кольцевого списка будем использовать новый класс списка CircularLinkedList, а класс itema можем взять DuplexItem
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("вывод списка после удаления эл.");
            circularList.Delete(3);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }




        }
    }
}
