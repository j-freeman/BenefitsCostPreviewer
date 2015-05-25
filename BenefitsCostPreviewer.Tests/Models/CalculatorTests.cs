using BenefitsCostPreviewer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenefitsCostPreviewer.Tests.Models
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void EmployeeWithNoDependants()
        {
            //Arrange
            var expectedBenefitsCost = 1000;
            var employee = new Employee { Name = "John" };
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }

        [TestMethod]
        public void EmployeeWithOneDependant()
        {
            //Arrange
            int expectedBenefitsCost = 1500;
            var employee = new Employee{Name = "Jack", Dependant1Name = "Jill"};
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }

        [TestMethod]
        public void EmployeeWithMultipleDependants()
        {
            //Arrange
            const int expectedBenefitsCost = 2000;
            var employee = new Employee{Name = "Bob", Dependant1Name = "Babs", Dependant2Name = "Billy"};
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }

        [TestMethod]
        public void EmployeeWithNoDependants_NameStartsWithLetter_A()
        {
            //Arrange
            const int expectedBenefitsCost = 900;
            var employee = new Employee{Name = "Alex"};
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }

        [TestMethod]
        public void EmployeeWithOneDependant_NameStartsWithLetter_A()
        {
            //Arrange
            const int expectedBenefitsCost = 1450;
            var employee = new Employee{Name = "Mark", Dependant1Name = "Alice"};
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }

        [TestMethod]
        public void EmployeeWithMultipleDependants_NameStartsWithLetter_A()
        {
            //Arrange
            const int expectedBenefitsCost = 2350;
            var employee = new Employee { Name = "Mark", Dependant1Name = "Alice", Dependant2Name = "Aaron", Dependant3Name = "amy"};
            var calculator = new Calculator();

            //Act
            calculator.CalculateBenefitsPreview(employee);

            //Assert
            Assert.AreEqual(employee.AnnualBenefitsCost, expectedBenefitsCost);
        }
    }
}
