using System;

namespace DependecyInjectionExample.IPerson
{
    public interface IPersonTransient
    {
        Guid ID { get; set; }
    }
}
