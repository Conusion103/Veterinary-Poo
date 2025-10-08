using Veterinary.Models;

namespace Veterinary.Databases;

public class DataBase
{
    public static List<Owner> Owners { get; set; }
    public static List<Pet> Pets { get; set; }
    public static List<Veterinarian> Veterinarians { get; set; }
    public static List<MedicalAppointment>  MedicalAppointments { get; set; }
}