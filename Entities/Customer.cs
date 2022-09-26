namespace Entities
{
    public class Customer : Person
    {
        #region Constructors
        public Customer(DateTime birthDate, string titleOfCourtesy, DateTime customerDate, int totalPurchases) : base(birthDate, titleOfCourtesy)
        {
            this.customerDate = customerDate;
            this.totalPurchases = totalPurchases;
        }

        public Customer(Person person, DateTime customerDate, int totalPurchases) : base(person.BirthDate, person.TitleOfCourtesy)
        {
            this.customerDate = customerDate;
            this.totalPurchases = totalPurchases;
        }
        #endregion

        #region Fields
        protected DateTime customerDate;
        protected int totalPurchases;
        #endregion

        #region Constructors
        public DateTime CustomerDate
        {
            get => customerDate;
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Datoen kan ikke være før 1900-tallet");
                }
                customerDate = value;
            }
        }

        public int TotalPurchases
        {
            get => totalPurchases;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Totalkøb kan ikke være i minus");
                }
                totalPurchases = value;
            }
        } 
        #endregion
    }
}