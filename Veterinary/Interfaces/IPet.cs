using Veterinary.Models;

namespace Veterinary.Interfaces;

public interface IPet
{
    Pet Add(Pet pet);
    Pet Update(Pet pet);
    Pet GetAll(List<Pet> pets);
    Pet Remove(int Id);
    Pet Get(int Id);
}