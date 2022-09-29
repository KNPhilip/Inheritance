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
        public Seller(DateTime birthDate, string titleOfCourtesy, string jobTitle, DateTime employmentDate, int thisYearsSales, decimal yearlySalary, string description, decimal yearlySold) : base(birthDate, titleOfCourtesy, jobTitle, employmentDate, thisYearsSales, yearlySalary)
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
        public override string GetRating()
        {
            if (ThisYearsSales >= 1000)
            {
                return $"Denne sælger er en uovertruffen sælger";
            }
            else if (ThisYearsSales >= 500)
            {
                return "Denne sælger er en fantastisk sælger";
            }
            else if (ThisYearsSales >= 250)
            {
                return "Denne sælger er en dygtig sælger";
            }
            else if (ThisYearsSales >= 100)
            {
                return "Denne sælger er en god sælger";
            }
            else
            {
                return "Denne sælger er en udmærket sælger";
            }

        }

        public decimal GetPercentageSoldOfSalary()
        {
            return yearlySalary / yearlySold;
        } 
        #endregion
    }
}