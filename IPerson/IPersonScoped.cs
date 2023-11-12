using System;

namespace DependecyInjectionExample.IPerson
{
    public interface IPersonScoped
    {
        Guid ID { get; set; }
    }
}
