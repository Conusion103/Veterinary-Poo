namespace Veterinary.Models;

public abstract class Person
{
    protected int Id { get; set; } 
    protected string Name { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Gender { get; set; }
    protected string Address { get; set; }
    protected string DocumentType { get; set; }
    protected int Document { get; set; }

    protected Person(int id, 
        string name, 
        DateOnly birthDate, 
        string gender, 
        string address, 
        string documentType, 
        int document)
    {
        
        Id = id;
        Name = name;
        BirthDate = birthDate;
        Gender = gender;
        Address = address;
        DocumentType = documentType;
        Document = document;
    }
}