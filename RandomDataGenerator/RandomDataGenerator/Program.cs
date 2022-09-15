// See https://aka.ms/new-console-template for more information
using RandomDataGenerator;

public class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        var option = 0;
        do
        {
            DisplayMenu();
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\nHit Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("------ Menu ------");
        Console.WriteLine("1. Create a new Person");
        Console.WriteLine("2. View all people");
        Console.WriteLine("3. Create a random last name");
        Console.WriteLine("4. Create a random phone number");
        Console.WriteLine("5. Create and View Random SSN");
        Console.WriteLine("6. Remove a person");
        Console.WriteLine("0. Exit");
        Console.WriteLine("------------------");
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();
        switch (option)
        {
            case 1:
                people.Add(new Person());
                break;
            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;
            case 3:
                Person rando1 = people[random.Next(people.Count)];
                Console.WriteLine(rando1.LastName);
                break;
            case 4:
                Person rando2 = people[random.Next(people.Count)];
                Console.WriteLine(rando2.Phone);
                break;

            
            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;

            case 6:
                people.Remove(new Person());
                break ;
            case 0:
                Console.WriteLine("Goodbye");
                break;
            default:
                Console.WriteLine("Invalid option. ");
                break;
        }
    }
}
