using DependecyInjectionExample.IPerson;
using System;

namespace DependecyInjectionExample.Person
{
    public class PersonTransient : IPersonTransient
    {
        public PersonTransient()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
    }
}
