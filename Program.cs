namespace LinqTopApp
{
    internal class Program
    {

        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        static void Main()
        {
            var listPersons = new List<Person>()
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };

            var list = new List<string>() { "1", "2", "3", "4", "5" };

            var l1 = list.Top(19);

            var l2 = listPersons.Top(34, person => person.Age);

        }
    }
}