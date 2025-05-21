//Uppgift 1: Vilka klasser bör ingå i programmet? 
//De bör ha en klass för anställda (employee), samt en för listan av anställda
//EmployeeRegister
//Uppgift 2: Vilka attribut och metoder bör ingå i dessa klasser?
//Klassen Employee bör ha:
//Attributen: Name, Salary
//Klassen EmployeeRegister bör ha:
//Attributen: List<Employee> Employees
//Metod: Vi använder oss av .Add() samt .ToString()
//Vi skapar även metoderna AddEmployer och PrintRegistry som lägger
//till en anställd i listan med klassen Employee, och PrintRegistry skriver
//ut listan på anställdas namn och lön.


namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.RegisterEmployee register = new();
            bool running = true;

            do
            {
                Console.WriteLine("\n*** Menu ***");
                Console.WriteLine("1. Add new employee");
                Console.WriteLine("2. Show register");
                Console.WriteLine("3. Exit program");
                Console.WriteLine("Please make a choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee salary in kr (SEK): ");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        register.AddEmployee(name, salary);
                        break;
                    case "2":
                        register.PrintRegistry();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Program exited successfully!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");

                        break;
                }

            } while (running);
        } 
    } 
}
