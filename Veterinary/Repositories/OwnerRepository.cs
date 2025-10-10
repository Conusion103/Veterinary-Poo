using Veterinary.Interfaces;
using Veterinary.Models;
using Veterinary.Services;

namespace Veterinary.Repositories;

public class OwnerRepository : IOwner
{
    public Owner Add(Owner owner)
    {
        Databases.DataBase.Owners.Add(owner);
        return owner;
    }

    public Owner UpdateName(Owner owner)
    {
            string newName = PersonServices.AskPersonNameValidation();
            owner.ChangeName(newName);
            return owner;

    }

    public Owner UpdateBirthdate(Owner owner)
    {
        DateOnly newBirthdate = PersonServices.PersonBirthdateValidation();
        owner.ChangeBirthDate(newBirthdate);
        return owner;
    }

    public Owner UpdateGender(Owner owner)
    {
        string gender = PersonServices.AskGender();
        owner.ChangeGender(gender);
        return owner;
        
    }

    public Owner UpdateAddress(Owner owner)
    {
        string address = PersonServices.AddressValidation();
        owner.ChangeAddress(address);
        return owner;
    }

    public Owner UpdateDocumentType(Owner owner)
    {
        string documentType = PersonServices.AskTypeDocument();
        owner.ChangeDocumentType(documentType);
        return owner;
    }

    public Owner UpdateDocument(Owner owner)
    {
        string document = PersonServices.DocumentValidation();
        owner.ChangeDocument(document);
        return owner;
    }

    public Owner UpdatePhoneNumber(Owner owner)
    {
        string phoneNumber = PersonServices.PhoneNumberValidation();
        owner.ChangePhoneNumber(phoneNumber);
        return owner;
        
    }

    public Owner? UpdateEmail(Owner owner)
    {
        string email = PersonServices.EmailValidation();
        owner.ChangeEmail(email);
        return owner;
    }
    

    public void GetAll()
    {
        if (Databases.DataBase.Owners != null)
        {
            foreach (var owner in Databases.DataBase.Owners)
            {
                Console.WriteLine(
                    $"Id: {owner.Id} Name: {owner.Name} Birthdate: {owner.BirthDate} Gender: {owner.Gender} DocumentType: {owner.DocumentType} Document: {owner.Document}");
            }
        }
    }
    
    public void Delete(int id, List<Owner> persons)
    {
        persons.RemoveAll(p => p.Id == id);
        
        
    }

    public string GetById()
    {
        Owner obj = PersonServices.AskId(Databases.DataBase.Owners);
        return $"Id: {obj.Id} Name: {obj.Name} Birthdate: {obj.BirthDate} Gender: {obj.Gender} DocumentType: {obj.DocumentType} Document: {obj.Document}";
    }
}