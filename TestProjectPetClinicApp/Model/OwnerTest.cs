using System;
using PetClinicApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProjectPetClinicApp.Model
{
    [TestClass]
    public class OwnerTest
    {
        [TestMethod]
        public void GetFullName_ReturnsFullName()
        {
            var owner = new Owner
            {
                Name = "Magdalena",
                Surname = "Miceva",
                Age = 32
            };

            // Act
            var fullName = owner.GetFullName();

            // Assert
            Assert.AreEqual("Magdalena Miceva", fullName);
        }
    }
}
