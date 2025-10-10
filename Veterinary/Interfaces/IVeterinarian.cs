using Veterinary.Models;

namespace Veterinary.Interfaces;

public interface IVeterinarian
{
    Veterinarian Add(Veterinarian vet);
    Veterinarian UpdateName(Veterinarian vet);
    Veterinarian UpdateBirthdate(Veterinarian vet);
    Veterinarian UpdateGender (Veterinarian vet);
    Veterinarian UpdateAddress(Veterinarian vet);
    Veterinarian UpdateDocumentType(Veterinarian vet);
    Veterinarian UpdateDocument(Veterinarian vet);
    Veterinarian UpdatePhoneNumber(Veterinarian vet);
    Veterinarian? UpdateEmail(Veterinarian vet);
    void GetAll();
    void Delete(int Id, List<Veterinarian> vet);
    string GetById();
}