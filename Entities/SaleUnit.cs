using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SaleUnit
    {
        #region Constructors
        public SaleUnit(string name, DateTime creationDate, Decimal price)
        {
            Name = name;
            CreationDate = creationDate;
            Price = price;
        }
        #endregion

        #region Fields
        protected string name;
        protected DateTime creationDate;
        protected Decimal price; 
        #endregion

        #region Properties
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Navnet kan ikke være null");
                }
                name = value;
            }
        }

        public DateTime CreationDate
        {
            get => creationDate;
            set
            {
                if (creationDate.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Oprettelsesdatoen skal være efter 1900-tallet");
                }
                creationDate = value;
            }
        }

        public Decimal Price
        {
            get => price;
            set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Prisen kan ikke være i minus");
                }
                price = value;
            }
        }
        #endregion
    }
}