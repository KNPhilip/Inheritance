using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Person
    {
        #region Constructors
        public Person(DateTime birthDate, string titleOfCourtesy)
        {
            BirthDate = birthDate;
            TitleOfCourtesy = titleOfCourtesy;
        }
        #endregion

        #region Fields
        private DateTime birthDate;
        private string titleOfCourtesy; 
        #endregion

        #region Properties
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Fødselsdagen skal være efter 1900-tallet.");
                }
                birthDate = value;
            }
        }

        public string TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title of Courtesy kan ikke være null");
                }
                titleOfCourtesy = value;
            }
        }
        #endregion

        #region Methods
        public abstract string GetRating();
        #endregion
    }
}