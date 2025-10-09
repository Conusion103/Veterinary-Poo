namespace Veterinary.Models;

public class Allison
{
    public int Id { get; set; }
    public string Name { get; set; }


    public Allison(int id, string name)
    {
        Id = id;
        Name = name;
    }
}