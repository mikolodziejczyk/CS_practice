using System;
using System.Collections.Generic;
using System.Text;

namespace CS
{
    class Person2
    {
        Person2()
        {
            FirstName = "John";
        }

        string FirstName { get; }
        string LastName { get; } = "Doe";
        IList<string> Ids { get; } = new List<string>() { "abc123" };
    }
}
