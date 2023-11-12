using DependecyInjectionExample.IPerson;
using System;

namespace DependecyInjectionExample.Person
{
    public class PersonScoped : IPersonScoped
    {
        public PersonScoped()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
    }
}
