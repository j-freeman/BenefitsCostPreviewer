using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BenefitsCostPreviewer.Models
{
    public class Employee
    {
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Display(Name = "Dependants")]
        public string Dependant1Name { get; set; }

        [Display(Name = "2nd Dependant")]
        public string Dependant2Name { get; set; }

        [Display(Name = "3rd Dependant")]
        public string Dependant3Name { get; set; }

        [Display(Name = "4th Dependant")]
        public string Dependant4Name { get; set; }


        [Display(Name = "Annual Salary")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int AnnualSalary { get; set; }
        

        [Display(Name = "Annual Benefits Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int AnnualBenefitsCost { get; set; }
        

        [Display(Name = "Pay Period Salary")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int PayPeriodSalary { get; set; }
        

        [Display(Name = "Pay Period Benefit Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int PayPeriodBenefitsCost { get; set; }
        
    }
}