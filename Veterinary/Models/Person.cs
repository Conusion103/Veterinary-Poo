namespace Veterinary.Models;

public abstract class Person
{
    public int Id { get; protected set; } 
    public string Name { get; protected set; }
    public DateOnly BirthDate { get; protected set; }
    public string Gender { get; protected set; }
    public string Address { get; protected set; }
    public string DocumentType { get; protected set; }
    public int Document { get; protected set; }

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