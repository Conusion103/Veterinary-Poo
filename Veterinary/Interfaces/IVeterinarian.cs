using Veterinary.Models;

namespace Veterinary.Interfaces;

public interface IVeterinarian
{
    Veterinarian Add(Veterinarian owner);
    Veterinarian Update(Veterinarian owner);
    Veterinarian GetAll(List<Veterinarian> owners);
    Veterinarian Remove(int Id);
    Veterinarian Get(int Id);
}