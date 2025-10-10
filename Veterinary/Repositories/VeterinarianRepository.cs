using Veterinary.Interfaces;
using Veterinary.Models;
using Veterinary.Services;

namespace Veterinary.Repositories;

public class VeterinarianRepository : IVeterinarian
{
    public Veterinarian Add(Veterinarian vet)
    {
        Databases.DataBase.Veterinarians.Add(vet);
        return vet;
    }

    public Veterinarian UpdateName(Veterinarian vet)
    {
        string newName = PersonServices.AskPersonNameValidation();
        vet.ChangeName(newName);
        return vet;
    }

    public Veterinarian UpdateBirthdate(Veterinarian vet)
    {
        DateOnly newBirthdate = PersonServices.PersonBirthdateValidation();
        vet.ChangeBirthDate(newBirthdate);
        return vet;
    }

    public Veterinarian UpdateGender(Veterinarian vet)
    {
        string gender = PersonServices.AskGender();
        vet.ChangeGender(gender);
        return vet;
    }

    public Veterinarian UpdateAddress(Veterinarian vet)
    {
        string address = PersonServices.AddressValidation();
        vet.ChangeAddress(address);
        return vet;
    }

    public Veterinarian UpdateDocumentType(Veterinarian vet)
    {
        string documentType = PersonServices.AskTypeDocument();
        vet.ChangeDocumentType(documentType);
        return vet;
    }

    public Veterinarian UpdateDocument(Veterinarian vet)
    {
        string document = PersonServices.DocumentValidation();
        vet.ChangeDocument(document);
        return vet;
    }

    public Veterinarian UpdatePhoneNumber(Veterinarian vet)
    {
        string phoneNumber = PersonServices.PhoneNumberValidation();
        vet.ChangePhoneNumber(phoneNumber);
        return vet;
    }

    public Veterinarian? UpdateEmail(Veterinarian vet)
    {
        string email = PersonServices.EmailValidation();
        vet.ChangeEmail(email);
        return vet;
    }

    public void GetAll()
    {
        if (Databases.DataBase.Veterinarians != null)
        {
            foreach (var vet in Databases.DataBase.Veterinarians)
            {
                Console.WriteLine(
                    $"Id: {vet.Id} Name: {vet.Name} Birthdate: {vet.BirthDate} Gender: {vet.Gender} DocumentType: {vet.DocumentType} Document: {vet.Document}");
            }
        }
    }

    public void Delete(int Id, List<Veterinarian> vet)
    {
        vet.RemoveAll(p => p.Id == Id);
    }

    public string GetById()
    {
        Veterinarian obj = PersonServices.AskId(Databases.DataBase.Veterinarians);
        return $"Id: {obj.Id} Name: {obj.Name} Birthdate: {obj.BirthDate} Gender: {obj.Gender} DocumentType: {obj.DocumentType} Document: {obj.Document}";
    }
}