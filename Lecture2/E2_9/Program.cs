using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E2_9.People;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Lan";
            person.Age = 28;
            person.HasPet = false;

            person.Greeting();
        }
    }
}





