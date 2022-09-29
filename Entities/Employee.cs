using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Employee : Person
    {
        #region Constructors
        public Employee(DateTime birthDate, string titleOfCourtesy, string jobTitle, DateTime employmentDate, int thisYearsSales, decimal yearlySalary) : base(birthDate, titleOfCourtesy)
        {
            JobTitle = jobTitle;
            EmploymentDate = employmentDate;
            ThisYearsSales = thisYearsSales;
            YearlySalary = yearlySalary;
        }
        #endregion

        #region Fields
        protected string jobTitle;
        protected DateTime employmentDate;
        protected int thisYearsSales;
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

        public decimal ThisYearsSales
        {
            get => thisYearsSales;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Nuværende årssalg kan ikke være i minus");
                }
                yearlySalary = value;
            }
        }

        public decimal YearlySalary
        {
            get => yearlySalary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Årsløn kan ikke være i minus");
                }
                yearlySalary = value;
            }
        }
        #endregion
    }
}