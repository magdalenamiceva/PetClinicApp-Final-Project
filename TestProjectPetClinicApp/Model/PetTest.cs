using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetClinicApp.Models;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;


namespace TestProjectPetClinicApp
{
    [TestClass]
    public class VaccinesModelTest
    {
        [TestMethod]
        public void VaccineProperties_AreSetCorrectly()
        {

            var pets = new List<Pet>
             {
             new() { Id = 1, Name = "Lisa", Age = 11 },
             new() { Id = 2, Name = "Lora", Age = 7 }
             };

            var vaccine = new Vaccine
            {
                Id = 3,
                Name = "Bordetella",
                Pets = pets
            };

            Assert.AreEqual(3, vaccine.Id);
            Assert.AreEqual("Bordetella", vaccine.Name);
            CollectionAssert.AreEqual(pets, vaccine.Pets);
        }
    }
}