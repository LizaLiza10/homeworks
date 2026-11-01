namespace homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Anna", "password123", "Anna@gmail.com");

            client.Authorize(Console.ReadLine(), Console.ReadLine());

            Admin admin = new Admin("Gio", "paroli123", "giorgi@gmail.com");

            client.Authorize(Console.ReadLine(), Console.ReadLine());


        }
    }
}
