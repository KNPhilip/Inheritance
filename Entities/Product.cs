using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : SaleUnit
    {
        #region Constructors
        public Product(string name, DateTime creationDate, decimal price, int numberOfSales) : base(name, creationDate, price)
        {
            NumberOfSales = numberOfSales;
        }

        public Product(SaleUnit saleUnit, int numberOfSales) : base(saleUnit.Name, saleUnit.CreationDate, saleUnit.Price)
        {
            NumberOfSales = numberOfSales;
        }
        #endregion

        #region Fields
        protected int numberOfSales;
        #endregion

        #region Properties
        public int NumberOfSales
        {
            get => numberOfSales;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Nummeret på salg kan ikke være i minus");
                }
                numberOfSales = value;
            }
        }
        #endregion
    }
}
