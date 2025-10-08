namespace Veterinary.Models;

public class Owner : Person
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<Pet> Pets { get; set; } = new List<Pet>();

    public Owner(int id, 
        string name, 
        DateOnly birthDate, 
        string gender, 
        string address, 
        string documentType, 
        int document,
        string phoneNumber,
        string email,
        List<Pet> pets) : 
        base(id, name, birthDate, gender, address, documentType, document)
    {
        PhoneNumber = phoneNumber;
        Email = email;
        Pets = pets;
    }
}