using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Seller : Employee
    {
        #region Constructors
        public Seller(DateTime birthDate, string titleOfCourtesy, string jobTitle, DateTime employmentDate, decimal yearlySalary, string description, decimal yearlySold) : base(birthDate, titleOfCourtesy, jobTitle, employmentDate, yearlySalary)
        {
            Description = description;
            YearlySold = yearlySold;
        }

        public Seller(Employee employee, string description, decimal yearlySold) : base(employee.BirthDate, employee.TitleOfCourtesy, employee.JobTitle, employee.EmploymentDate, employee.YearlySalary)
        {
            Description = description;
            YearlySold = yearlySold;
        }
        #endregion

        #region Fields
        protected string description;
        protected decimal yearlySold;
        #endregion

        #region Properties
        public string Description
        {
            get => description;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Beskrivelsen kan ikke være null");
                }
                description = value;
            }
        }

        public decimal YearlySold
        {
            get => yearlySold;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salget kan ikke være i minus");
                }
                yearlySold = value;
            }
        }
        #endregion

        #region Methods
        public decimal GetPercentageSoldOfSalary()
        {
            return yearlySalary / yearlySold;
        } 
        #endregion
    }
}