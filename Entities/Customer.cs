namespace Entities
{
    public class Customer : Person
    {
        #region Constructors
        public Customer(DateTime birthDate, string titleOfCourtesy, DateTime customerDate, decimal totalPurchases) : base(birthDate, titleOfCourtesy)
        {
            CustomerDate = customerDate;
            TotalPurchases = totalPurchases;
        }

        public Customer(Person person, DateTime customerDate, decimal totalPurchases) : base(person.BirthDate, person.TitleOfCourtesy)
        {
            CustomerDate = customerDate;
            TotalPurchases = totalPurchases;
        }
        #endregion

        #region Fields
        protected DateTime customerDate;
        protected decimal totalPurchases;
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

        public decimal TotalPurchases
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

        #region Methods
        public override string GetRating()
        {
            if (TotalPurchases >= 1000)
            {
                return "*****";
            }
            else if (TotalPurchases >= 500)
            {
                return "****";
            }
            else if (TotalPurchases >= 250)
            {
                return "***";
            }
            else if (TotalPurchases >= 100)
            {
                return "**";
            }
            else
            {
                return "*";
            }

        }
        #endregion
    }
}