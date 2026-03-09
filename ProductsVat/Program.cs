namespace ProductsVat
{
    /// <summary>
    /// Reads a product price from the console, calculate the VAT (24%) and the
    /// total price including VAT, and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποιήση μεταβλητών
            const double VAT_RATE = 0.24;

            double newPrice = 0D;
            double price = 0D;
            double vat = 0D;

            // Εισαγωγή δεδομένων, data binding and validation
            Console.WriteLine("Δώστε Τιμή προιόντος");
            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τιμή.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            vat = price * VAT_RATE;
            newPrice = price + vat;

            // Εμφάνιση αποτελεσμάτων
            Console.WriteLine($"{"Ποσό χωρίς ΦΠΑ:",-10} {price:N2}$");
            Console.WriteLine($"{"Ποσό με ΦΠΑ για το γάλα είναι:",-10} {newPrice:N2}$");
            Console.WriteLine($"{"Το ΦΠΑ για το γάλα είναι:",-10} {vat:N2}$");
    }
    }
}
