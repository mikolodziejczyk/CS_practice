using System;
using System.Collections.Generic;
using System.Text;

namespace CS
{
    class Person2
    {
        public Person2()
        {
            FirstName = "John";
        }

        public string FirstName { get; }
        public string LastName { get; } = "Doe";
        public IList<string> Ids { get; } = new List<string>() { "abc123" };
    }
}
