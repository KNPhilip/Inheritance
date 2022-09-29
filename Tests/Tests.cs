using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;

namespace Tests
{
    public class Tests
    {
        #region Customer tests
        [Fact]
        public void ValidCustomerProperties()
        {
            // Arrange:
            DateTime correctBirthDate;
            string correctTitleOfCourtesy;
            DateTime correctDate;
            int correctTotalPurchases;
            Person p;
            Customer c;

            // Act:
            correctBirthDate = new(2000, 01, 01);
            correctTitleOfCourtesy = "Title Of  Courtesy";
            correctDate = DateTime.Now;
            correctTotalPurchases = 5;
            c = new(correctBirthDate, correctTitleOfCourtesy, correctDate, correctTotalPurchases);


            // Assert:
            Assert.False(String.IsNullOrWhiteSpace(c.TitleOfCourtesy));
            Assert.False(c.BirthDate.Year < 1900);
            Assert.False(c.CustomerDate.Year < 1900);
            Assert.False(c.TotalPurchases <= 0);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidCustomerProperties()
        {
            // Arrange:
            Func<Customer> call;
            string correctTitleOfCourtesy;
            DateTime correctBirthDate;
            DateTime incorrectCustomerDate;
            int incorrectTotalPurchases;

            // Act:
            correctBirthDate = new(2000, 01, 01);
            correctTitleOfCourtesy = "Title Of Courtesy";
            incorrectCustomerDate = new(1500, 01, 01);
            incorrectTotalPurchases = -1;
            call = () => new Customer(correctBirthDate, correctTitleOfCourtesy, incorrectCustomerDate, incorrectTotalPurchases);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidCustomerMutation()
        {
            // Arrange:
            Func<Customer> call;
            DateTime correctBirthDate;
            string correctTitleOfCourtesy;
            DateTime incorrectCustomerDate;
            int incorrectTotalPurchases;

            // Act:
            correctBirthDate = new(1500, 01, 01);
            correctTitleOfCourtesy = "Title Of Courtesy";
            incorrectCustomerDate = new(1500, 01, 01);
            incorrectTotalPurchases = -1;
            call = () => new Customer(correctBirthDate, correctTitleOfCourtesy, incorrectCustomerDate, incorrectTotalPurchases);

            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion

        #region Employee tests
        [Fact]
        public void ValidEmployeeProperties()
        {
            // Arrange:
            DateTime correctBirthDate;
            string correctTitleOfCourtesy;
            string correctJobTitle;
            DateTime correctEmploymentDate;
            decimal correctYearlySalary;
            int correctThisYearsSales;
            string correctDescription;
            decimal correctYearlySold;
            Seller s;

            // Act:
            correctBirthDate = new(2000, 01, 01);
            correctTitleOfCourtesy = "Salesman";
            correctEmploymentDate = DateTime.Now;
            correctJobTitle = "Salesman";
            correctThisYearsSales = 20;
            correctYearlySalary = 300000.00m;
            correctDescription = "God sælger";
            correctYearlySold = 20;
            s = new(correctBirthDate, correctTitleOfCourtesy, correctJobTitle, correctEmploymentDate, correctThisYearsSales, correctYearlySalary, correctDescription, correctYearlySold);


            // Assert:
            Assert.False(String.IsNullOrWhiteSpace(s.TitleOfCourtesy));
            Assert.False(String.IsNullOrWhiteSpace(s.JobTitle));
            Assert.False(s.BirthDate.Year < 1900);
            Assert.False(s.EmploymentDate.Year < 1900);
            Assert.False(s.YearlySalary < 0);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidEmployeeProperties()
        {
            // Arrange:
            Func<Seller> call;
            string correctTitleOfCourtesy;
            DateTime correctBirthDate;
            DateTime incorrectEmploymentDate;
            decimal incorrectYearlySalary;
            int incorrectThisYearsSales;
            string incorrectJobTitle;
            string correctDescription;
            decimal correctYearlySold;


            // Act:
            correctBirthDate = new(2000, 01, 01);
            correctTitleOfCourtesy = "Title of Courtesy";
            incorrectEmploymentDate = new(1500, 01, 01);
            incorrectThisYearsSales = -1;
            incorrectYearlySalary = -1;
            correctDescription = "God sælger";
            correctYearlySold = 20;
            incorrectJobTitle = null;
            call = () => new Seller(correctBirthDate, correctTitleOfCourtesy, incorrectJobTitle, incorrectEmploymentDate, incorrectThisYearsSales, incorrectYearlySalary, correctDescription, correctYearlySold);


            // Assert:
            Assert.Throws<ArgumentNullException>(call);
        }
        #endregion

        #region Seller tests
        [Fact]
        public void ValidSellerProperties()
        {
            // Arrange:
            string correctJobTitle;
            DateTime correctEmploymentDate;
            decimal correctYearlySalary;
            string correctDescription;
            decimal correctYearlySold;
            int correctThisYearsSales;
            Seller s;

            // Act:
            correctEmploymentDate = DateTime.Now;
            correctJobTitle = "Salesman";
            correctYearlySalary = 300000.00m;
            correctDescription = "Im a very good salesman";
            correctThisYearsSales = 1;
            correctYearlySold = 100000;
            s = new(DateTime.Now, "Title of Courtesy", correctJobTitle, correctEmploymentDate, correctThisYearsSales, correctYearlySalary, correctDescription, correctYearlySold);


            // Assert:
            Assert.False(String.IsNullOrWhiteSpace(s.TitleOfCourtesy));
            Assert.False(String.IsNullOrWhiteSpace(s.JobTitle));
            Assert.False(String.IsNullOrWhiteSpace(s.Description));
            Assert.False(s.BirthDate.Year < 1900);
            Assert.False(s.EmploymentDate.Year < 1900);
            Assert.False(s.YearlySalary < 0);
            Assert.False(s.YearlySold < 0);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidSellerProperties()
        {
            // Arrange:
            Func<Employee> call;
            string correctTitleOfCourtesy;
            DateTime correctBirthDate;
            DateTime correctEmploymentDate;
            decimal correctYearlySalary;
            string correctJobTitle;
            string incorrectDescription;
            decimal incorrectYearlySold;
            int correctThisYearsSales;


            // Act:
            correctBirthDate = new(2000, 01, 01);
            correctEmploymentDate = new(2022, 01, 01);
            correctTitleOfCourtesy = "Title of  Courtesy";
            correctYearlySalary = 50000;
            correctJobTitle = "Salesman";
            correctThisYearsSales = -1;
            incorrectDescription = null;
            incorrectYearlySold = -1;
            call = () => new Seller(correctBirthDate, correctTitleOfCourtesy, correctJobTitle, correctEmploymentDate, correctThisYearsSales, correctYearlySalary, incorrectDescription, incorrectYearlySold);


            // Assert:
            Assert.Throws<ArgumentNullException>(call);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidSellerMutation()
        {
            // Arrange:
            Func<Seller> call;
            string correctTitleOfCourtesy;
            DateTime correctBirthDate;
            DateTime correctEmploymentDate;
            string correctJobTitle;
            decimal correctYearlySalary;
            int correctThisYearsSales;
            decimal incorrectYearlySold;
            string incorrectDescription;

            // Act:
            correctJobTitle = "Salesman";
            correctYearlySalary = 5000;
            correctEmploymentDate = new(2022, 01, 01);
            correctBirthDate = new(2000, 01, 01);
            correctTitleOfCourtesy = "Title of Courtesy";
            correctThisYearsSales = 20;
            incorrectDescription = null;
            incorrectYearlySold = -1;
            call = () => new Seller(correctBirthDate, correctTitleOfCourtesy, correctJobTitle, correctEmploymentDate, correctThisYearsSales, correctYearlySalary, incorrectDescription, incorrectYearlySold);

            // Assert:
            Assert.Throws<ArgumentNullException>(call);
        }
        #endregion

        #region Service tests
        [Fact]
        public void ValidServiceProperties()
        {
            // Arrange:
            string correctName;
            DateTime correctCreationDate;
            Decimal correctPrice;
            string correctDescription;

            // Act:
            correctName = "Remoulade";
            correctCreationDate = DateTime.Now;
            correctPrice = 10;
            correctDescription = "Smager godt";
            Service s = new(correctName, correctCreationDate, correctPrice, correctDescription);


            // Assert:
            Assert.False(s.Name == null);
            Assert.False(s.CreationDate.Year < 1900);
            Assert.False(s.Price < 0);
            Assert.False(s.Description == null);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidServiceProperties()
        {
            // Arrange:
            Func<Service> call;
            string correctName;
            DateTime correctCreationDate;
            Decimal correctPrice;
            string incorrectDescription;

            // Act:
            correctName = "Remoulade";
            correctCreationDate = new(2020, 01, 01);
            correctPrice = 10;
            incorrectDescription = null;
            call = () => new Service(correctName, correctCreationDate, correctPrice, incorrectDescription);


            // Assert:
            Assert.Throws<ArgumentNullException>(call);
        }
        #endregion

        #region Product tests
        [Fact]
        public void ValidProductProperties()
        {
            // Arrange:
            string correctName;
            DateTime correctCreationDate;
            Decimal correctPrice;
            int correctNumberOfSales;

            // Act:
            correctName = "Remoulade";
            correctCreationDate = DateTime.Now;
            correctPrice = 10;
            correctNumberOfSales = 5;
            Product p = new(correctName, correctCreationDate, correctPrice, correctNumberOfSales);


            // Assert:
            Assert.False(p.Name == null);
            Assert.False(p.CreationDate.Year < 1900);
            Assert.False(p.Price < 0);
            Assert.False(p.NumberOfSales < 0);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidProductProperties()
        {
            // Arrange:
            Func<Product> call;
            string correctName;
            DateTime correctCreationDate;
            Decimal correctPrice;
            int incorrectNumberOfSales;

            // Act:
            correctName = "Remoulade";
            correctCreationDate = new(2020, 01, 01);
            correctPrice = 10;
            incorrectNumberOfSales = -1;
            call = () => new Product(correctName, correctCreationDate, correctPrice, incorrectNumberOfSales);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion

        #region Sale tests
        [Fact]
        public void ValidSaleProperties()
        {
            // Arrange:
            Seller correctSeller;
            Customer correctCustomer;
            DateTime correctDateOfSale;
            List<SaleUnit> correctSaleUnits;

            // Act:
            correctSeller = new(new(2020, 01, 01), "Title Of Courtesy", "Salesman", new(2020, 01, 01), 20, 20.00m, "God sælger", 20.00m);
            correctCustomer = new(new(2020, 01, 01), "Title Of Courtesy", new(2020, 01, 01), 20);
            correctDateOfSale = new(2020, 01, 01);
            Product su1 = new("Makrel", new(2020, 01, 01), 8, 2);
            Service su2 = new("Remoulade", new(2020, 01, 01), 10, "Smager sgu godt");

            List<SaleUnit> su = new();
            su.Add(su1);
            su.Add(su2);

            Sale s = new(correctSeller, correctCustomer, correctDateOfSale, su);

            // Assert:
            Assert.False(s.Seller == null);
            Assert.False(s.Customer == null);
            Assert.False(s.DateOfSale.Year < 1900);
            Assert.False(s.SaleUnits == null);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidSaleProperties()
        {
            // Arrange:
            Func<Sale> call;

            // Act:
            call = () => new Sale(new (new(1500, 01, 01), null, null, new(1500, 01, 01), -1, -1, null, -1), new(new(1500, 01, 01), null, new(1500, 01, 01), -1), new(1500, 01, 01), null);

            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion

        #region Method tests
        [Fact]
        public void ValidSellerGetRatingMethod()
        {
            // Arrange:
            string correctJobTitle;
            DateTime correctEmploymentDate;
            decimal correctYearlySalary;
            string correctDescription;
            decimal correctYearlySold;
            int correctThisYearsSales;
            Seller s;

            // Act:
            correctEmploymentDate = DateTime.Now;
            correctJobTitle = "Salesman";
            correctYearlySalary = 300000.00m;
            correctDescription = "Im a very good salesman";
            correctThisYearsSales = 1;
            correctYearlySold = 100000;
            s = new(DateTime.Now, "Title of Courtesy", correctJobTitle, correctEmploymentDate, correctThisYearsSales, correctYearlySalary, correctDescription, correctYearlySold);

            string actualOutput = s.GetRating();
            string expectedOutput = "Denne sælger er en udmærket sælger";

            // Assert:
            Assert.Equal(expectedOutput, actualOutput);
        }
        #endregion
    }
}