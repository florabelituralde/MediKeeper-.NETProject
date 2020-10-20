using System;
using System.Collections.Generic;
using System.Text;
using Medikeeper_Project.Models;
using Medikeeper_Project.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using System.Linq;

namespace WellnessShop.Test
{
    public class StoreControllerTests
    {
        [Fact]
        public void CanUseRepository()
        {
            // Arrange
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Stores).Returns((new Store[] {
            new Store {Id = 1, Name = "P1"},
            new Store {Id = 2, Name = "P2"}
            }).AsQueryable<Store>());
            HomeController controller = new HomeController(mock.Object);
            // Act
            IEnumerable<Store> result =
            (controller.Index() as ViewResult).ViewData.Model
            as IEnumerable<Store>;
            // Assert
            Store[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P1", prodArray[0].Name);
            Assert.Equal("P2", prodArray[1].Name);
        }
    }
}