using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int yob { get; set; }
        public int yod { get; set; }

        //Default Constructor 
        public Person()
        {
            id = 0;
            name = " ";
            yob = 0;
            yod = 0;
        }
        //Copy constructor
        public Person(Person p)
        {
            id = p.id;
            name = p.name;
            yob = p.yob;
            yod = p.yod;
        }
        //Nhap, xuat du lieu
        public void Input()
        {
            Console.Write("Nhap id nguoi: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam mat: ");
            yod = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Nam sinh: " + yob);
            Console.WriteLine("Nam mat: " + yod);
        }
        
        public bool IsLiving()
        {
            if (yod == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
