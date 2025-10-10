using Veterinary.Models;
using Veterinary.Repositories;

namespace Veterinary.Services;

public class VeterinarianServices
{
    private static readonly VeterinarianRepository Conection = new VeterinarianRepository();
    public static List<MedicalAppointment> AddMedicalVeterinarian()
    {
        List<MedicalAppointment> medicals = new List<MedicalAppointment>();
        return medicals;

    }
    
    public static void AddVeterinarian(List<Veterinarian> veterinarians)
    {
        int Id = PersonServices.IdPerson<Veterinarian>(veterinarians);
        string Name = PersonServices.AskPersonNameValidation();
        DateOnly Birthdate = PersonServices.PersonBirthdateValidation();
        string Gender = PersonServices.AskGender();
        string Address = PersonServices.AddressValidation();
        string TypeDocument = PersonServices.AskTypeDocument();
        string Document = PersonServices.DocumentValidation();
        string Phone = PersonServices.PhoneNumberValidation();
        string Email = PersonServices.EmailValidation();
        List<MedicalAppointment> medicals = AddMedicalVeterinarian();
        var veterinarian = new Veterinarian(Id,
            Name,
            Birthdate,
            Gender,
            Address,
            TypeDocument,
            Document,
            Phone,
            Email,
            medicals);
        Conection.Add(veterinarian);
    }
    
    
}