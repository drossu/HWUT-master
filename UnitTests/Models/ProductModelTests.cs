using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange
            int[] defaultRating = new int[] { 5 };

            // Act
            var result = new ProductModel();
            // Assert
            CollectionAssert.AreEqual(defaultRating, result.Ratings);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_ID_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass_Null()
        {
            //Arrange

            //Act
            var result = new ProductModel();

            //Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Id = "Test";

            //Assert
            Assert.AreEqual("Test", result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Maker = "Test";

            //Assert
            Assert.AreEqual("Test", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Image = "Test";

            //Assert
            Assert.AreEqual("Test", result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Url = "Test";

            //Assert
            Assert.AreEqual("Test", result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Title = "Test";

            //Assert
            Assert.AreEqual("Test", result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Description = "Test";

            //Assert
            Assert.AreEqual("Test", result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();

            //Act
            result.Sequence = "Test";

            //Assert
            Assert.AreEqual("Test", result.Sequence);
        }

        [TestMethod]

        public void ProductModel_ToString_Default_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();
            DateTime buildTime = result.Date;
            string currTime = JsonSerializer.Serialize<DateTime>(buildTime);
            string check = "{\"Id\":null,\"Maker\":null,\"img\":null,\"Url\":null,\"Title\":null,\"Description\":null,\"Date\":";
            check += currTime;
            check += ",\"Sequence\":null,\"Email\":\"Unknown\",\"Logistics\":\"\",\"Ratings\":[5]}";

            //Act
            string toS = result.ToString();

            //Assert
            Assert.AreEqual(check, toS);
        }

        [TestMethod]

        public void ProductModel_AverageRating_Default_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();
            int average;

            //Act
            average = result.AverageRating();

            //Assert
            Assert.AreEqual(5, average);
        }

        [TestMethod]

        public void ProductModel_AverageRating_NullRatings_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();
            result.Ratings = null;
            int average;

            //Act
            average = result.AverageRating();

            //Assert
            Assert.AreEqual(0, average);
        }

        [TestMethod]

        public void ProductModel_AverageRating_No_Ratings_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();
            result.Ratings = new int[0];
            int average;

            //Act
            average = result.AverageRating();

            //Assert
            Assert.AreEqual(0, average);
        }

        [TestMethod]

        public void ProductModel_AverageRating_Zeroed_Ratings_Should_Pass()
        {
            //Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { 0 };
            int average;

            //Act
            average = result.AverageRating();

            //Assert
            Assert.AreEqual(0, average);
        }
    }
}
