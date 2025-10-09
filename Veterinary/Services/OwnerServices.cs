using Veterinary.Models;
using Veterinary.Repositories;


namespace Veterinary.Services;

public class OwnerServices
{
   private static readonly OwnerRepository Conection = new OwnerRepository();
   public static List<Pet> AddPetList()
   {
      List<Pet> pets = new List<Pet>();
      return pets;
   }

   public static void AddOwner(List<Owner>  owners)
   {
      int Id = PersonServices.IdPerson<Owner>(owners);
      string Name = PersonServices.AskPersonNameValidation();
      DateOnly Birthdate = PersonServices.PersonBirthdateValidation();
      string Gender = PersonServices.AskGender();
      string Address = PersonServices.AddressValidation();
      string TypeDocument = PersonServices.AskTypeDocument();
      string Document = PersonServices.DocumentValidation();
      string Phone = PersonServices.PhoneNumberValidation();
      string Email = PersonServices.EmailValidation();
      List<Pet> Pets= AddPetList();
      var owner = new Owner(Id,
         Name,
         Birthdate,
         Gender,
         Address,
         TypeDocument,
         Document,
         Phone,
         Email,
         Pets);
      Conection.Add(owner);

   }

   public static void UpdateOwner()
   {
      
      Conection.UpdateName()
      
   }





}