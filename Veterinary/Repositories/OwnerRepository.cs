using Veterinary.Interfaces;
using Veterinary.Models;

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
        throw new NotImplementedException();
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

    public Owner Get(int Id)
    {
        throw new NotImplementedException();
    }
}