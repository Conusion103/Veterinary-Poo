namespace Veterinary.Models;

public class Pet : Animal
{
    public string Name { get; set; }
    public int OwnerId { get; set; }
    
    public Pet(int id, 
        string species, 
        string breed, 
        string gender, 
        string color, 
        string name, 
        int ownerId) 
        : base(id, species, breed, gender, color)
    {
        Name = name;
        OwnerId = ownerId;
    }


     
}