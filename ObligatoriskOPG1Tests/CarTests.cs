using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOPG1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ObligatoriskOPG1.Tests
{
    
    [TestClass()]
    public class CarTests
    {
        private Car CarSuccess = new Car { Id = 1, Model = "Ford Focus", Price = 230000, Plate = "XYZ123" };
        private Car CarShortModel = new Car { Id = 2, Model = "Kia", Price = 212000, Plate = "XYZ123" };
        private Car CarNullModel = new Car { Id = 3, Model = null, Price = 212000, Plate = "XYZ123" };
        private Car CarBrokenPrice = new Car { Id = 4, Model = "Kia Picanto", Price = -12, Plate = "XYZ123" };
        private Car CarShortPlate = new Car { Id = 5, Model = "BMW I3", Price = 650000, Plate = "A" };
        private Car CarLongPlate = new Car { Id = 6, Model = "Mercedes Jokester", Price = 950000, Plate = "ABCDEFGHIJKL" };
        private Car CarNullPlate = new Car { Id = 7, Model = "Mini Cooper", Price = 550000, Plate = null };

        [TestMethod()]
        public void ValidateCarModelTest()
        {
            CarSuccess.ValidateCarModel();
            Assert.ThrowsException<ArgumentException>(() => CarShortModel.ValidateCarModel());
            Assert.ThrowsException<ArgumentNullException>(() => CarNullModel.ValidateCarModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            CarSuccess.ValidatePrice();
            Assert.ThrowsException<ArgumentException>(() => CarBrokenPrice.ValidatePrice());
        }

        [TestMethod()]
        public void ValidatePlateTest()
        {
            CarSuccess.ValidatePlate();
            Assert.ThrowsException<ArgumentException>(() => CarShortPlate.ValidatePlate());
            Assert.ThrowsException<ArgumentException>(() => CarLongPlate.ValidatePlate());
            Assert.ThrowsException<ArgumentNullException>(() => CarNullPlate.ValidatePlate());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            CarSuccess.Validate();
        }
        [TestMethod()]
        public void ToStringTest()
        {
            string str = CarSuccess.ToString();   // act
            Assert.AreEqual("ID: 1, Model: Ford Focus, Price: 230000, Plate: XYZ123", str);  // assert
        }
    }
}