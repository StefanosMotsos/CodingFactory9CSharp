namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var allNumbers = from num in numbers select num;

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
        }
    }
}
