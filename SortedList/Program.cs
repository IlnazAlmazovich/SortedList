using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //создаём коллекцию 
                SortedList<int, string> name  = new SortedList<int, string>()  {
                    //заполняем коллекцию данными 
                    {1, "Ильназ" },
                    {3, "Адиля" },
                    {2, "Ваня"},
                    {5, "Миша" }
                };
                Console.WriteLine("Список:");
                //выводим коллекцию
                foreach (var i in name)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                //Добавление
                Console.WriteLine("Список после добавления: ");
                name.Add(4, "Софа");
                name.Add(7, "Ильдина");
                name.Add(8, "Фангиз");
                foreach (var item in name)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                //Удадение
                Console.WriteLine("Список после удаления: ");
                name.Remove(2); //удаление по ID
                name.RemoveAt(0); //удаляет по указанному индексу
                foreach (var item in name)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                //Получаем только ключи
                Console.WriteLine("Ключи записей:");
                ICollection<int> k = name.Keys;
                foreach (var i in k)
                {
                    Console.WriteLine(i);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
                Console.ReadKey();
        }
    }
}
