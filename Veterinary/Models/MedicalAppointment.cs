namespace Veterinary.Models;

public class MedicalAppointment
{
    int Id { get; set; }
    int VeterinarianId { get; set; }
    int OwnerId { get; set; }
    int PetId { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    string Symptoms { get; set; }

    public MedicalAppointment(int id, 
        int veterinarianId, 
        int ownerId, 
        int petId, 
        DateTime startDate, 
        DateTime endDate, 
        string symptoms)
    {
        Id = id;
        VeterinarianId = veterinarianId;
        OwnerId = ownerId;
        PetId = petId;
        StartDate = startDate;
        EndDate = endDate;
        Symptoms = symptoms;
    }
}