using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        #region Constructors
        public Person(DateTime birthDate, string titleOfCourtesy)
        {
            this.birthDate = birthDate;
            this.titleOfCourtesy = titleOfCourtesy;
        }
        #endregion

        #region Fields
        protected DateTime birthDate;
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
                    throw new ArgumentNullException("Fødselsdagen skal være efter 1900-tallet.");
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
    }
}