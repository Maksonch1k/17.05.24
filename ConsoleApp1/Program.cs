using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ClassTaker(Class1 class1)
        {
            class1.change = "изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            //Class1 class1 = new Class1();
            //class1.change = "не изменено";

            //MyStruct myStruct = new MyStruct();
            //myStruct.change = "не изменено";

            //Console.WriteLine("исход. знач");
            //Console.WriteLine("class1.change " + class1.change);
            //Console.WriteLine("myStruct.change " + myStruct.change);
            //Console.WriteLine();

            //ClassTaker(class1);
            //StructTaker(myStruct);

            //Console.WriteLine("после вызова методов");
            //Console.WriteLine("Class1.change " + class1.change);

            //Notebook notebook = new Notebook("Notebook X", "ABC Company", 400);
            //notebook.DisplayInfo();
            List<Book> list = new List<Book>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine($"1-добавление элемента\n 2 - выход всех элементов\n 3 - выход");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        list.Add(Book.Enter());
                        break;
                    case '2':
                        foreach (var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case '3': return;
                }
                Console.ReadKey();
            }
        }
    }
}
