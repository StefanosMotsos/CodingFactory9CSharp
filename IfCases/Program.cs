namespace IfCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string name = "Alice";
            string nickname = "Ally";

            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else 
            { 
                Console.WriteLine("Underage");
            }

            var status = age > 18 ? "adult" : "underage";
            Console.WriteLine(status);

            var displayName = name ?? "unknown";
            Console.WriteLine(displayName);

            var length = name?.Length ?? 0;
            Console.WriteLine(length);
        }
    }
}
