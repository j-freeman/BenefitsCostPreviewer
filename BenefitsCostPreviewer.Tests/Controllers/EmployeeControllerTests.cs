using System.Web.Mvc;
using BenefitsCostPreviewer.Controllers;
using BenefitsCostPreviewer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenefitsCostPreviewer.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public void Details()
        {
            // Arrange
            var employee = new Employee{Name = "John"};
            var controller = new EmployeeController();

            // Act
            ViewResult result = controller.Details(employee) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}