// This program tracks how many times each activity has been
// completed during the current session. The totals are displayed
// in the menu and updated whenever an activity is finished.

class Program
{
    static int breathingCount = 0;
    static int reflectionCount = 0;
    static int listingCount = 0;

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine($"1. Start Breathing Activity ({breathingCount})");
            Console.WriteLine($"2. Start Reflection Activity ({reflectionCount})");
            Console.WriteLine($"3. Start Listing Activity ({listingCount})");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                listingCount++;
            }
        }
    }
}