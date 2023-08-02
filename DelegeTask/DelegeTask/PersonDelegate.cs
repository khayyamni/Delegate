using DelegeTask;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeTask
{
    internal class PersonDelegate
    {

        //1) Person tipinden listimiz var.
        //    Maashi 1000-den cox olan personlarin ad, soyad ve addresini gosteren ve parametr olaraq predicate qebul eden method yazin.

        public void PersonMethod()
        {


            List<Person> list = new();
            list.Add(new Person { Id = 1, FullName = "Ismayil Efendizade", Adress = "Yasamal", Salary = 550 });
            list.Add(new Person { Id = 2, FullName = "Samir Qehremanov", Adress = "Sumqayit", Salary = 1300 });
            list.Add(new Person { Id = 4, FullName = "Kubra Memmedova", Adress = "Xalqlar Dostlugu", Salary = 2000 });
            list.Add(new Person { Id = 5, FullName = "Pervin Mirzeyev", Adress = "Bileceri", Salary = 850 });

            FilterBySalary(list, m => m.Salary > 1000);

        }
        public void FilterBySalary(List<Person> persons, Predicate<Person> func)
        {
            foreach (var person in persons)
            {
                if (func(person))
                {
                    Console.WriteLine($"{person.FullName}");
                }
            }
        }


        //2) Book tipinden listimiz olacaq.Authoru  Nizami olan book-larin sayini gosteren ve predicate qebul eden method yazin.


        public void BookMethod()
        {
            
            List<Book> list = new List<Book>();

            list.Add(new Book { Id = 1, Name = "Xosrov ve Shirin", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 1, Name = "Isgendername", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 1, Name = "Isgenderome", Author = "Nizami Gencevi" });
            list.Add(new Book { Id = 1, Name = "Xosrov ve Shirin", Author = "nizami Gencevi" });

            var result = list.Where(m => m.Author == "Nizami Gencevi").Count();

            Console.WriteLine(result);
        }
       


    }
}
