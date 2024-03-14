/*using System;
namespace Educal
{
    public static class Menu
    {
        public static void DisplayMainMenu(Calendar calendar)
        {
            while (true)
            {
                Console.WriteLine("1. File");
                Console.WriteLine("2. Edit");
                Console.WriteLine("3. About");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayFileMenu(calendar);
                        break;

                    case "2":
                        DisplayEditMenu(calendar);
                        break;

                    case "3":
                        DisplayAboutMenu();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static void DisplayFileMenu(Calendar calendar)
        {
            Console.WriteLine("File Menu");
            Console.WriteLine("1. New");
            Console.WriteLine("2. Open");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Save As...");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("1. New Event");
                    Console.WriteLine("2. New Calendar");
                    // Add additional options if needed
                    Console.Write("Enter your choice: ");
                    string newChoice = Console.ReadLine();
                    // Handle the choice accordingly
                    break;

                case "2":
                    Console.WriteLine("Opening File Dialog...");
                    // Implement file opening logic
                    break;

                case "3":
                    Console.WriteLine("Saving current file...");
                    // Implement file saving logic
                    break;

                case "4":
                    Console.WriteLine("Opening Save File Dialog...");
                    // Implement save file dialog logic
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        private static void DisplayEditMenu(Calendar calendar)
        {
            Console.WriteLine("Edit Menu");
            Console.WriteLine("1. Event");
            Console.WriteLine("2. Settings");
            // Add additional options if needed
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Opening Event Form...");
                    // Implement opening event form logic
                    break;

                case "2":
                    Console.WriteLine("Opening Settings Form...");
                    // Implement opening settings form logic
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        private static void DisplayAboutMenu()
        {
            Console.WriteLine("About Menu");
            // Implement logic to display information about the application
        }
    }
}
*/