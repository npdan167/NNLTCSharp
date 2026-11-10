using System;
using System.Collections;

namespace TH02
{
    public class PersonList
    {
        //Field
        public ArrayList listPerson;
        //Constructor mac nhien
        public PersonList()
        {
            listPerson = new ArrayList();
        }
        //Constructor sao chep
        public PersonList(PersonList p)
        {
            listPerson = new ArrayList();

            foreach (Person person in p.listPerson)
            {
                listPerson.Add(new Person(person));
            }
        }
        public void Input()
        {
            Console.Write("Nhap so luong nguoi: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap nguoi: ");
                Person p = new Person();
                p.Input();
                Add(p);
            }
        }
        public void Output()
        {
            foreach (Person p in listPerson)
            {
                p.Output();

            }
        }
        public void Add(Person x)
        {
            listPerson.Add(x);
        }

        // Tra ve danh sach nguoi con song
        public PersonList LivingPeople()
        {
            PersonList kq = new PersonList();
            foreach (Person p in listPerson)
            {
                if (p.IsLiving())
                {
                    kq.Add(new Person(p));
                }
            }
            return kq;
        }
    }
}