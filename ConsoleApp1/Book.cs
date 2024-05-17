using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string name;
        public string fio;
        public DateTime date;
        public int kolvo;
        public Book(string name, string fio, DateTime date, int kolvo)
        {
            this.name = name;
            this.fio = fio;
            this.date = date;
            this.kolvo = kolvo;
        }
        public void Print()
        {
            Console.WriteLine($"название{name}\nфио автора:{fio}\nдата издания{date.ToShortDateString()}\nколво страниц{kolvo}");
            
        }
        public static Book Enter()
        {
            Console.WriteLine("ведите название");
            string name = Console.ReadLine();
            Console.WriteLine("введите фио автора");
            string fio = Console.ReadLine();
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите колво страниц");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            return new Book(name, fio, date, kolvo);
        }

    }
}
