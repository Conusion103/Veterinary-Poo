using Veterinary.Models;
using Veterinary.Repositories;


namespace Veterinary.Services;

public class OwnerServices
{
    private static readonly OwnerRepository Conection = new OwnerRepository();

    public static List<Pet> AddPetList()
    {
        List<Pet> pets = new List<Pet>();
        return pets;
    }

    public static void AddOwner(List<Owner> owners)
    {
        int Id = PersonServices.IdPerson<Owner>(owners);
        string Name = PersonServices.AskPersonNameValidation();
        DateOnly Birthdate = PersonServices.PersonBirthdateValidation();
        string Gender = PersonServices.AskGender();
        string Address = PersonServices.AddressValidation();
        string TypeDocument = PersonServices.AskTypeDocument();
        string Document = PersonServices.DocumentValidation();
        string Phone = PersonServices.PhoneNumberValidation();
        string Email = PersonServices.EmailValidation();
        List<Pet> Pets = AddPetList();
        var owner = new Owner(Id,
            Name,
            Birthdate,
            Gender,
            Address,
            TypeDocument,
            Document,
            Phone,
            Email,
            Pets);
        Conection.Add(owner);
    }

    public static void UpdateOwnerName(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateName(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerBirthdate(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateBirthdate(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerGender(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateGender(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerAddress(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateAddress(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerTypeDocument(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateDocumentType(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerDocument(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdateDocument(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public static void UpdateOwnerPhone(List<Owner> owners)
    {
        if (!PersonServices.IsEmptyListPerson(owners))
        {
            Owner? owner = PersonServices.AskId(owners);
            if (owner != null)
            {
                Conection.UpdatePhoneNumber(owner);
                Conection.Delete(owner.Id, owners);
                Conection.Add(owner);
            }
            else
            {
                Console.WriteLine("Owner not found");
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }
}