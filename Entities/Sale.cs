using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sale
    {
        #region Constructors
        public Sale(Seller seller, Customer customer, DateTime dateOfSale, List<SaleUnit> saleUnits)
        {
            Seller = seller;
            Customer = customer;
            DateOfSale = dateOfSale;
            SaleUnits = saleUnits;
        }
        #endregion

        #region Fields
        private Seller seller;
        private Customer customer;
        private DateTime dateOfSale;
        private List<SaleUnit> saleUnits;
        #endregion

        #region Properties
        public Seller Seller
        {
            get => seller;
            set
            {
                if (seller == null)
                {
                    throw new ArgumentNullException("Sælgeren kan ikke være null");
                }
                seller = value;
            }
        }

        public Customer Customer
        {
            get => customer;
            set
            {
                if (customer == null)
                {
                    throw new ArgumentNullException("Kunden kan ikke være null");
                }
                customer = value;
            }
        }

        public DateTime DateOfSale
        {
            get => dateOfSale;
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Oprettelsesåret kan ikke være før 1900-tallet");
                }
                dateOfSale = value;
            }
        }

        public List<SaleUnit> SaleUnits
        {
            get => saleUnits;
            set
            {
                if (saleUnits == null)
                {
                    throw new ArgumentNullException("Salgsenheder kan ikke være null");
                }
                saleUnits = value;
            }
        }
        #endregion

        #region Methods
        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (SaleUnit saleUnit in SaleUnits)
            {
                total += saleUnit.Price;
            }
            return total;
        } 
        #endregion
    }
}