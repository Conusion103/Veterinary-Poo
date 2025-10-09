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

    public Owner UpdateName(int id)
    {
        var existingOwner = Databases.DataBase.Owners
            .FirstOrDefault(o => o.Id == id);

        if (existingOwner != null)
        {
            string newName = PersonServices.AskPersonNameValidation();
            existingOwner.ChangeName(newName);
            return existingOwner;
        }

        return null!;
    }

    public Owner UpdateBirthdate(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner UpdateGender(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner UpdateAddress(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner UpdateDocumentType(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner UpdateDocument(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner UpdatePhoneNumber(Owner owner)
    {
        throw new NotImplementedException();
    }

    public Owner? UpdateEmail(Owner owner)
    {
        throw new NotImplementedException();
    }
    

    public Owner GetAll(List<Owner> owners)
    {
        throw new NotImplementedException();
    }

    public Owner Remove(int Id)
    {
        throw new NotImplementedException();
    }

    public Owner GetById(int Id)
    {
        throw new NotImplementedException();
    }
}