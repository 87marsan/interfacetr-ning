namespace interfaceträning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Kalle", Age = 20 };
            var account = new BankAccount { Name = "Saving Account", AccountNumber = "123456789" };
            GetName(person);
            GetName(account);
        }

        private static void FindStuff(string name, List<Person> lst)
        {
            foreach (var item in lst)
            {
                if (item.Name == name)
                {
                    Console.WriteLine(item.Name + " " + item.Age);
                }
            }
        }
        private static void FindStuff(string name, List<BankAccount> lst)
        {
            foreach (var item in lst)
            {
                if (item.Name == name)
                {
                    Console.WriteLine(item.Name + " " + item.AccountNumber);
                }
            }
        }
        private static void GetName(INameable nameable)
        {
            Console.WriteLine(nameable.Name);
        }
    }
}