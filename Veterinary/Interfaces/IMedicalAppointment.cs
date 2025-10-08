using Veterinary.Models;

namespace Veterinary.Interfaces;

public interface IMedicalAppointment
{
    MedicalAppointment Add(MedicalAppointment medicalAppointment);
    MedicalAppointment Update(MedicalAppointment medicalAppointment);
    MedicalAppointment GetAll(List<MedicalAppointment> medicalAppointments);
    MedicalAppointment Remove(int Id);
    MedicalAppointment Get(int Id);
    
}