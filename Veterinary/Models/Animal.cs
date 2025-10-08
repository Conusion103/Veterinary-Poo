namespace Veterinary.Models;

public abstract class Animal
{
    protected int Id { get; set; }
    protected string Species { get; set; }          
    protected string Breed { get; set; }            
    protected string Gender { get; set; }           
    protected DateOnly BirthDate { get; set; }      
    protected string Color { get; set; }            
    protected double Weight { get; set; }


    public Animal(int id, string species, string breed, string gender, string color)
    {
        Id = id;
        Species = species;
        Breed = breed;
        Gender = gender;
        Color = color;
    }
}