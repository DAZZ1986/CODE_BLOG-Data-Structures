using System;

namespace _1_Связный_список__linked_list_.Model
{
    /// <summary>
    /// Ячейка списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        /// <summary>
        /// Данные хранимые в ячейке списка.
        /// </summary>
        private T data = default(T);    // default(T); - это просто значение по умолчанию
        // создаем свойства
        public T Data   //это данные
        {
            get { return data; }
            /*
            set 
            {
                data = value ?? throw new ArgumentNullException(nameof(value)); // ?? - означает, что если мы в value передали null, то
                                                                                // то выполняем то что справа, тоесть эксепшон, а если
                                                                                // value не null, то выполняем то что слева, тоесть
                                                                                // присваиваем сначение value в data.
                                                                            // Оператор nameof возвращает имя класса, имя метода,
                                                                            // имя переменной. Вычисляется во время компиляции.
            }
            */
            // аналогичная запись set как выше, только в классическом варианте, без использования оператора объединения с NULL ??.
            set { if(value != null) data = value; else throw new ArgumentNullException(nameof(value)); }
        }

        public Item<T> Next { get; set; }   //это указатель на следующую ячейку списка



        public Item(T data) // конструктор
        {
            Data = data;
        }


        //переопределяем ToString()
        public override string ToString()
        {
            return Data.ToString();
        }





    }
}
