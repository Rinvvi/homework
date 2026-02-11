using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{


    //задание1
    class Student
    {
        public string name = "";

        public void Print()
        {
            Console.WriteLine($"Имя:{name}");

        }
    }

    //задание2
    class Car
    {
        public int year = 11;
    }

    //задание3
    class Point
    {
        public int x;
    }


    //задание4
    class Person
    {
        public int age;
        public void Print()
        {
            Console.WriteLine($"Возраст:{age}");
        }

    }


    //задание5
    class Table
    {
        public int rows;
        public int cols;

        public void Display()
        {
            Console.WriteLine($"Строчки:{rows}, Столбики:{cols}");
        }
    }


    //задание6
    class Manager
    {
        public int age;
        public string name;

        public void GetAge()
        {
            Console.WriteLine($"Возраст: {age}");
        }

        public void GetName()
        {
            Console.WriteLine($"Имя: {name}");
        }
    }


    //задание7
    class Point3D
    {
        public int x;
        public int y;
        public int z;

        public void Show()
        {
            Console.WriteLine($"Значение x: {x}, y: {y}, z: {z} ");
        }

    }



    //задание8
    class Shop
    {
        public string name;
        public string newname;

        public void GetName()
        {
            Console.WriteLine($"Название магазина: {name}");
        }


        public void SetName()
        {
            Console.WriteLine($"Новое название магазина: {newname}");
        }
    }


    internal class Program//задание1
    {
        static void Main(string[] args)
        {
            //задание1
            {
                Student p1 = new Student();
                p1.name = "Arianna";
                p1.Print();
            }

            //задание4
            {
                Person person1 = new Person();
                person1.age = 17;
                person1.Print();
            }


            //задание5
            {
                Table table1 = new Table();
                table1.rows = 10;
                table1.cols = 20;
                table1.Display();
            }

            //задание6
            {
                Manager manager1 = new Manager();
                manager1.age = 17;
                manager1.name = "Arianna";
                manager1.GetName();
                manager1.GetAge();

            }


            //задание7
            {
                Point3D point3D = new Point3D();
                point3D.x = 3;
                point3D.y = 6;
                point3D.z = 12;
                point3D.Show();
            }

            //задание8
            {
                Shop shop = new Shop();
                shop.name = "АPio";
                shop.newname = "Momi";
                shop.GetName();
                shop.SetName();
            }


        }
    }
}