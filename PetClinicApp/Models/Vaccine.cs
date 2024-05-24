using System.ComponentModel;

namespace PetClinicApp.Models
{
    public class Vaccine
    {
        public int Id { get; set; }
        [DisplayName("Vaccine Name")]
        public string Name { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
