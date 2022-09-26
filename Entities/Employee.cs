using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person
    {
        #region Constructors
        public Employee(DateTime birthDate, string titleOfCourtesy, string jobTitle, DateTime employmentDate, decimal yearlySalary) : base(birthDate, titleOfCourtesy)
        {
            this.jobTitle = jobTitle;
            this.employmentDate = employmentDate;
            this.yearlySalary = yearlySalary;
        }
        #endregion

        #region Fields
        protected string jobTitle;
        protected DateTime employmentDate;
        protected decimal yearlySalary; 
        #endregion

        #region Properties
        public string JobTitle
        {
            get => jobTitle;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Jobtitlen kan ikke være null");
                }
                jobTitle = value;
            }
        }

        public DateTime EmploymentDate
        {
            get => employmentDate;
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Ansættelsesdatoen skal være efter 1900-tallet.");
                }
                employmentDate = value;
            }
        }

        public decimal YearlySalary
        {
            get => yearlySalary;
            set
            {
                if (YearlySalary < 0)
                {
                    throw new ArgumentOutOfRangeException("Årsløn kan ikke være i minus");
                }
                yearlySalary = value;
            }
        } 
        #endregion
    }
}