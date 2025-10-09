using Veterinary.Models;

namespace Veterinary.Services;

public class PersonServices
{
    public static int IdPerson<T>(List<T> persons) where T : Person
    {
        return persons.Count == 0 ? 1 : persons.Max(p => p.Id)+1;
    }

    private static string? AskPersonName()
    {
        Console.WriteLine("Enter name of person");
        return Console.ReadLine().Trim();
    }
    public static string AskPersonNameValidation()
    {
        string? input = AskPersonName();
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error! Enter valid name of person");
            input = Console.ReadLine().Trim();
        }

        return input;
    }

    private static string? AskBirthDate()
    {
        Console.WriteLine("Enter Birthdate");
        return Console.ReadLine().Trim();
    }

    public static DateOnly PersonBirthdateValidation()
    {
        string? input = AskBirthDate();
        DateOnly date;
        while (string.IsNullOrWhiteSpace(input) || !DateOnly.TryParse(input, out date))
        {
            Console.WriteLine("Error! Enter valid birth date");
            input = Console.ReadLine();
        }
        return date;
    }

    public static string AskGender()
    {
        while (true)
        {
            Console.WriteLine($"Enter gender of person" +
                              $"1. M" +
                              $"2. F" +
                              $"3. O");


            string input = Console.ReadLine();
            switch (input)
            {
                case "M":
                    return "Male";
                case "F":
                    return "Female";
                case "O":
                    return "Other";
                default:
                    continue;
            }
        }
    }

    private static string? AskAddress()
    {
        Console.WriteLine("Enter address");
        return Console.ReadLine();
    }

    public static string AddressValidation()
    {
        string? input = AskAddress();
        while (string.IsNullOrWhiteSpace(AskAddress()))
        {
            Console.WriteLine("Error! Enter valid address");
            input = Console.ReadLine();
            
        }
        return input;
    }
    public static string AskTypeDocument()
    {
        while (true)
        {
            Console.WriteLine($"Enter type of document" +
                              $"1. C.C" +
                              $"2. C.E" +
                              $"3. P.A");


            string input = Console.ReadLine();
            switch (input)
            {
                case "C.C":
                    return "Cedula de Ciudadanía";
                case "C.E":
                    return "Cedula de extranjería";
                case "P.A":
                    return "Pasaporte";
                default:
                    continue;
            }
        }
    }

    private static string? AskDocument()
    {
        Console.WriteLine("Enter document");
        return Console.ReadLine();
    }

    public static string DocumentValidation()
    {
        string? input = AskDocument();
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error! Enter valid document");
            input = Console.ReadLine();
        }
        return input;
    }
    
}






