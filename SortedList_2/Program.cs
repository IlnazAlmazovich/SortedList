using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дана пустая коллекция SortedList. 
            //Заполнить коллекцию где: ID генерируется случайным способом, а значения беруться и созданного списка
            //Затем пользователь вводит число. Определить есть ли запись с таким ID
            //Далее программа должна удалить запись с ID котрый ввёл пользователь
            //вывести на консоль значение записи который был удалён
            try
            {
                List<string> name = new List<string>()
                {
                    "Белов Юрий",
                    "Сафина Ильдина",
                    "Платонова Полина",
                    "Рюхова Софья",
                    "Кулыев Денис",
                    "Строй Владислав",
                    "Данилова Даша",
                    "Кузнецова Лера"
                };

                SortedList<int, string> list = new SortedList<int, string>();
                Random rnd = new Random();
                foreach (var item in name)
                {
                    int id = rnd.Next(0,100);
                    list.Add(id, item);
                }
                foreach (var i in list)
                {
                  Console.WriteLine($"Id = {i.Key}; Значение = {i.Value}");

                }
                Console.WriteLine();

                Console.WriteLine("Введите число: ");
                int k = Convert.ToInt32(Console.ReadLine());

                if (list.ContainsKey(k))
                {
                    Console.WriteLine($"Запись с ID {k} = {list[k]}");  
                    Console.WriteLine($"Студент {list[k]} и с ID {k} отчислен(-а) из техникума");
                    list.Remove(k);
                }
                else
                {
                    Console.WriteLine($"Студента с ID {k} нет в техникуме ");
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
