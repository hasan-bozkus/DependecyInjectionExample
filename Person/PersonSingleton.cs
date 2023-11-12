using DependecyInjectionExample.IPerson;
using System;

namespace DependecyInjectionExample.Person
{
    public class PersonSingleton : IPersonSingleton
    {
        public PersonSingleton() 
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
    }
}
