namespace Veterinary.Models;

public class Owner : Person
{
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public List<Pet> Pets { get; private set; } = new List<Pet>();

    public Owner(int id, 
        string name, 
        DateOnly birthDate, 
        string gender, 
        string address, 
        string documentType, 
        string document,
        string phoneNumber,
        string email,
        List<Pet> pets) : 
        base(id, name, birthDate, gender, address, documentType, document)
    {
        PhoneNumber = phoneNumber;
        Email = email;
        Pets = pets;
    }

    public void ChangePhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void ChangeEmail(string email)
    {
        Email = email;
    }

}