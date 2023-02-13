namespace NetModificsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user = new User("Bob", "Smith");
            Console.WriteLine(user.Name);

            Employe employe = new("Joe");
           

        }
    }
}