using System;

namespace _1_Связный_список__linked_list_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Структуры данных C#
            /*
            Структуры данных - позволяют нам упорядочить данные и тогда с ними можно комфортно работать.
            
            Зачем нужны структуры данных - представим себе библиотеку, где много книг и если книги будут хаотично разбросаны, 
            то искать конкретную книгу можно очень долго. К примеру мы можем расставить все книги в алфавитном порядке, тогда 
            проблема уходит, тк мы четко понимаем в каком порядке осуществлять поиск. Это уже по сути структура данных, тк 
            из просто хаотически наваленной кипы книг, мы сделали упорядоченную последовательность по алфавиту. 
            Так же мы можем помимо упорядочивания по алфавиту, взять и расставить их на отдельные стелажи, где один стелаж 
            будет с буквой "А", следующий стелаж с буквой "Б", итд. Это и есть структура данных! 

            Структуры данных делятся на 2 основных типа: 
            1. Линейные - это означает, что информация упорядочена в одном направлении, друг за другом, к примеру массив. 
            2. Не линейные - это данные по структуре как дерево.




            //////////////////////////////////////////////////////



            Односвязный связный список (linked list) - Структуры данных C#
            linked list - представляет из себя пару, представим цепочку: D,N - D,N - D,N
                      внутри цепочки лежат данные(D-data), например int:  1     2     3
                      ,а (N-next) это указатель на наш на след. элемент и они идут цепокой друг за другом пока не дойдем до 
            крайнего элемента который указывает на null. Это самый простой односвязный список.
            
            Три основных вида связных списоков:
            1. Односвязный(однонаправленный) - это когда мы можем переходит от одного эл. к другому только в одном направлении.
            Тут чтобы к примеру от 3 эл. нам нужно попасть ко 2, то нам нужно идти с начала.
            2. Двусвязный(двунаправленный) - тут мы можем переходит в обе стороны.
            3. Кольцевой - это когда у нас список зациклен по кругу. (1-2-3-1)




            //////////////////////////////////////////////////////
            ///
            Просто вопрос от пользователя
            Выгода по памяти на связном списке или на связном списке(LinkedList) на основе массива?
            Когда мы берем на основые массива, у нас эл. упорядоченны в памяти и лежат рядом и чтение будет происходить быстрее, а когда
            мы делаем обычный связный список то эл. могут быть сильно фрагментированны, тоесть разбросаны по памяти и чтение будет дольше.
            Поэтому нужно смотреть, если нужно больше читать и список не будет бесконечно расширяться, то выбираем на основе массива, а если
            мы расчитываем что список будет расти неимоверными размерами то логичнее лучше сделать связный список.По памяти массив выгоднее.
            */


            //ДАЛЕЕ реализуем нашу модель, создаем папку Model и в ней создаем класс элемента Item - это как раз таки элемент нашего
            //списка. В классе Item используем Generic (class Item<T>) для того чтобы, данные внутри нашего списка были строгого типа.

            //ДАЛЕЕ создаем класс самого списка LinkedList

            //ДАЛЕЕ создаем наш список
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("вывод до удаления");
            foreach (var item in list) //вывод до удаления
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);


            Console.WriteLine("||||||| ДАЛЕЕ сделаем так чтобы наш список можно было нормально выводить");
            //ДАЛЕЕ сделаем так чтобы наш список можно было нормально выводить, перебирать, чтобы он у нас был коллекцией. Для этого
            //делаем наш класс коллекции LinkedList<T> наследником интерфейса IEnumarable и это позволит нам выводить нашу коллекцию при
            //помощи цикла foreach.
            Console.WriteLine("вывод после удаления");
            foreach (var item in list) //вывод после удаления
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();




            Console.WriteLine("||||||| ДАЛЕЕ очистить наш список полностью");
            //ДАЛЕЕ очистить наш список полностью - создали метод Clear() в классе коллекции LinkedList.




            Console.WriteLine("||||||| ДАЛЕЕ добавить эл. в начало списка");
            //ДАЛЕЕ добавить эл. в начало списка - создали метод AppendHead() в классе коллекции LinkedList.
            list.AppendHead(222); //добавили эл. в начало списка

            foreach (var item in list) //вывод после добавления эл. в начало списка
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            Console.WriteLine("||||||| ДАЛЕЕ делаем вставку после элемента");
            //ДАЛЕЕ делаем вставку после элемента
            list.InsertAfter(2, 333); //таргет-222, дата-333

            foreach (var item in list) //вывод после вставки
            {
                Console.Write(item + " "); 
            }
            Console.WriteLine();











        }
    }
}
