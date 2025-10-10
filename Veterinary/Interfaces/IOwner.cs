using Veterinary.Models;

namespace Veterinary.Interfaces;

public interface IOwner 
{
    Owner Add(Owner owner);
    Owner UpdateName(Owner owner);
    Owner UpdateBirthdate(Owner owner);
    Owner UpdateGender (Owner owner);
    Owner UpdateAddress(Owner owner);
    Owner UpdateDocumentType(Owner owner);
    Owner UpdateDocument(Owner owner);
    Owner UpdatePhoneNumber(Owner owner);
    Owner? UpdateEmail(Owner owner);
    void GetAll();
    void Delete(int Id, List<Owner> owners);
    string GetById();
}