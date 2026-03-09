namespace TravelingApp
{
    /// <summary>
    /// Reads fuel consumption (liters/100km) and distance (km) from the user,
    /// calculates the total needed for the trip and the total cost, and
    /// prints the result formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποιήση μεταβλητών
            const double FUEL_PRICE = 1.85D;

            double consumption = 0D;
            double distance = 0D;
            double totalLiters = 0D;
            double totalCost = 0D;

            // Εισαγωγή δεδομένων, data binding and validation
            Console.WriteLine("Δώστε κατανάλωση (λίτρα/100km)");
            if (!double.TryParse(Console.ReadLine(), out consumption) || consumption < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για κατανάλωση.");
                return;
            }
            Console.WriteLine("Δώστε απόσταση (km)");
            if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για χιλιόμετρα.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            totalLiters = Math.Round(consumption * distance) / 100;
            totalCost = Math.Round(totalLiters * FUEL_PRICE, 2);

            // Εμφάνιση αποτελεσμάτων
            Console.WriteLine($"{"Κατανάλωση ανά 100km:",-25} {consumption:N2}");
            Console.WriteLine($"{"Απόσταση:",-25} {distance:N2}");
            Console.WriteLine($"{"Λίτρα που χρειάζονται:",-25} {totalLiters:N2}");
            Console.WriteLine($"{"Συνολικό Κόστος:",-25} {totalCost:N2}");

        }
    }
}
