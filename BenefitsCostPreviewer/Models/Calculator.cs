namespace BenefitsCostPreviewer.Models
{
    public class Calculator
    {
        public void CalculateBenefitsPreview(Employee employee)
        {
            CalculateSalary(employee);
            CalculateBenefitsCost(employee);
        }

        public void CalculateBenefitsCost(Employee employee)
        {
            employee.AnnualBenefitsCost = employee.Name.ToUpper().StartsWith("A") ? 900 : 1000;
            if (employee.Dependant1Name != null) employee.AnnualBenefitsCost += employee.Dependant1Name.ToUpper().StartsWith("A") ? 450 : 500;
            if (employee.Dependant2Name != null) employee.AnnualBenefitsCost += employee.Dependant2Name.ToUpper().StartsWith("A") ? 450 : 500;
            if (employee.Dependant3Name != null) employee.AnnualBenefitsCost += employee.Dependant3Name.ToUpper().StartsWith("A") ? 450 : 500;
            if (employee.Dependant4Name != null) employee.AnnualBenefitsCost += employee.Dependant4Name.ToUpper().StartsWith("A") ? 450 : 500;

            employee.PayPeriodBenefitsCost = employee.AnnualBenefitsCost / 26;
        }

        public void CalculateSalary(Employee employee)
        {
            employee.AnnualSalary = 2000 * 26;
            employee.PayPeriodSalary = 2000;

        }
    }
}