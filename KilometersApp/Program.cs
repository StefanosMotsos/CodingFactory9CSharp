namespace KilometersApp
{
    /// <summary>
    /// Reads a distance in kilometers from the console/user,
    /// converts it to meters, centimeters and miles, and 
    /// prints the result, formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποιήση μεταβλητών
            const double METERS_PER_KM = 1000D;
            const double CM_PER_KM = 100000D;
            const double MILES_PER_KM = 0.621371D;

            double kilometers = 0D;
            double meters = 0D;
            double centimeters = 0D;
            double miles = 0D;

            // Εισαγωγή δεδομένων, data binding and validation
            Console.WriteLine("Δώστε χιλιόμετρα");
            if (!double.TryParse(Console.ReadLine(), out kilometers) || kilometers < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για χιλιόμετρα.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            meters = kilometers * METERS_PER_KM;
            centimeters = kilometers * CM_PER_KM;
            miles = kilometers * MILES_PER_KM;

            // Εμφάνιση αποτελεσμάτων
            Console.WriteLine($"{"Χιλιόμετρα:",-20} {kilometers:N2} km");
            Console.WriteLine($"{"Μέτρα:",-20} {meters:N2} m");
            Console.WriteLine($"{"Εκατοστά:",-20} {centimeters:N2} cm");
            Console.WriteLine($"{"Μίλια:",-20} {miles:N2} mi");
        }
    }
}
