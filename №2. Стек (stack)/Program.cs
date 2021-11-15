using _2._Стек__stack_.Models;
using System;
using System.Collections.Generic;

namespace _2._Стек__stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Стек (stack) - Структуры данных C#
            /*
            Рассматриваем стек - когда может быть его переполнение, stackoverflow итд.
            Стэк - это структура для организации данных, которая позволяет осуществлять доступ к данным только с одной стороны. Аналогия с 
            банкой Pringles, когда мы сверху можем взять чипсину и сверху можем ее положить, тоесть доступ только с одной стороны. Но к 
            нижней чипсине мы доступ не имеем, пока все верхние не достанем. 

            Стек можно представить как банку Pringles, когда снаружи у нас находится один единственный верхний элемент, и через него мы 
            можем работать только следующими способами:
            Peek - посмотреть эл. в стеке ничего с ним ни делая.
            Pop  - достать эл. из стека.
            Push - протолкнуть эл. в стек, вниз, соответственно наш стек сдвинется вниз, а новый эл. добавится сверху.
            Вот так и работает стек, тоесть мы можем получить доступ только к одному эл. сверху, а все остальные эл. которые находятся
            в стеке нам не доступны.

            Стек может быть реализован несколькими способами, самые простые способы: 
            1. List - это реализация стека на основе, либо массива, либо списка. Это означает что у нас уже есть коллекция для перечисления
            и мы делаем над ней обертку. Тоесть у нас есть List, а над листом мы делаем обертку. И даем доступ только к одному крайнему эл.,
            и либо добавляем суда, либо убираем от суда. 
            2. LinkedList - либо стек может быть реализован как связный список, когда у нас есть item'ы, которые между собой связываются. И 
            тут мы будем иметь доступ только к одному первому элементу, и остальные эл. в цепочке как бы будут проталкиваться дальше.
            
            КОГДА нам может понадобиться стек - когда нам нужно обеспечить доступ только к одному верхнему элементу. Тоесть мы что то, 
            взяли в обработку и с этим работаем, с тем что у нас находится на поверхности. Н/П: для фитнес приложения - стек может нам 

            */



            Console.WriteLine("||||||||Создали стэк EasyStack, на списке(List)");
            //ДАЛЕЕ создали класс class EasyStack сам стек и делаем над ним обертку
            EasyStack<int> easyStack = new EasyStack<int>();

            easyStack.Push(1); //проталкиваем в стек 1
            easyStack.Push(2);
            easyStack.Push(3);

            var item = easyStack.Pop();
            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);




            Console.WriteLine("|||||||| В .NET в Generic уже есть готовый список Stack<double>");
            //ДАЛЕЕ вообще в .NET в Generic уже есть готовый список который мы можем использовать и у него есть теже самые операции, Push
            //Peek, Pop. Только есть отличие, Stack реализован не на списке(List), а на массиве.
            Stack<double> stack = new Stack<double>();
            stack.Push(1); //проталкиваем в стек 1
            stack.Push(2);
            stack.Push(3);

            var itemS = stack.Pop();
            var itemS2 = stack.Peek();

            Console.WriteLine(itemS);
            Console.WriteLine(itemS2);






            Console.WriteLine("||||||||Создали стэк LinkedStack, на связном списке");
            // создаем класс Item<T> и LinkedStack<T>
            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);

            Console.WriteLine(linkedStack.Peek()); //посмотрели верхний эл.
            Console.WriteLine(linkedStack.Pop());  //вытащили верхний эл.
            Console.WriteLine(linkedStack.Pop());  //вытащили еще один верхний эл.
            Console.WriteLine(linkedStack.Peek()); //снова посмотрели какой теперь верхний эл.





            Console.WriteLine("||||||||Создали стэк ArrayStack, на основе массива");
            var arrayStack = new ArrayStack<int>(5);
            Console.WriteLine(arrayStack.Count); //кол-во эл. в массиве - тут 0 тк он пустой.
            arrayStack.Push(100);
            Console.WriteLine(arrayStack.Count); //кол-во эл. в массиве - тут 1 тк записали 1 эл.
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek()); //посмотрели верхний эл.
            Console.WriteLine(arrayStack.Pop());  //вытащили верхний эл.
            Console.WriteLine(arrayStack.Pop());  //вытащили еще один верхний эл.
            Console.WriteLine(arrayStack.Peek()); //снова посмотрели какой теперь верхний эл.






        }
    }
}
