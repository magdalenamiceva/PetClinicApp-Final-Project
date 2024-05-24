using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetClinicApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [DisplayName("Owner Name")]
        public string Name { get; set; }
        [DisplayName("Owner Surname")]
        public string Surname { get; set; }
        [Range(18, 100, ErrorMessage = "Add age between 18 and 100.")]
        [DisplayName("Owner Age")]
        public int Age { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}
