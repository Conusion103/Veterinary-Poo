namespace Veterinary.Models;
public class Veterinarian : Person
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<MedicalAppointment> Appointments { get; set; } = new List<MedicalAppointment>();
    
    public Veterinarian(int id, 
        string name, 
        DateOnly birthDate, 
        string gender, 
        string address, 
        string documentType, 
        int document, 
        string phoneNumber, 
        string email,
        List<MedicalAppointment> appointments) 
        : base(id, name, birthDate, gender, address, documentType, document)
    {
        PhoneNumber = phoneNumber;
        Email = email;
        Appointments = appointments;
    }


    
    
}