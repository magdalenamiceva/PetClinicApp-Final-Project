using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PetClinicApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [DisplayName("Pet Name")]
        public string Name { get; set; }
        [Range(0, 50, ErrorMessage = "Add age between 0 and 50.")]
        [DisplayName("Pet Age")]
        public int Age { get; set; }
        [Display(Name = "Owner")]
        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
        [NotMapped]
        public List<int> VaccinesParams { get; set; }
    }
}
