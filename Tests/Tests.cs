namespace Tests
{
    public class Tests
    {
        #region Person tests
        [Fact]
        public void ValidPersonProperties()
        {
            // Arrange:
            DateTime correctDate;
            string correctTitleOfCourtesy;

            // Act:
            correctDate = DateTime.Now;
            correctTitleOfCourtesy = "Title of Courtesy";
            Person p = new(correctDate, correctTitleOfCourtesy);


            // Assert:
            Assert.False(p.TitleOfCourtesy == null);
            Assert.False(p.BirthDate.Year < 1900);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidPersonProperties()
        {
            // Arrange:
            Func<Person> call;
            DateTime incorrectBirthDate;
            string incorrectTitleOfCourtesy;

            // Act:
            incorrectBirthDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            call = () => new Person(incorrectBirthDate, incorrectTitleOfCourtesy);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidPersonMutation()
        {
            // Arrange:
            Func<Person> call;
            Person p = new(DateTime.Now, "Title of Courtesy");
            DateTime incorrectDate;
            string incorrectTitleOfCourtesy;

            // Act:
            incorrectDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            call = () => new Person(incorrectDate, incorrectTitleOfCourtesy);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion

        #region Customer tests
        [Fact]
        public void ValidCustomerProperties()
        {
            // Arrange:
            DateTime correctDate;
            int correctTotalPurchases;
            Person p;
            Customer c;

            // Act:
            correctDate = DateTime.Now;
            correctTotalPurchases = 5;
            p = new(DateTime.Now, "Title of Courtesy");
            c = new(p, correctDate, correctTotalPurchases);


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
            string incorrectTitleOfCourtesy;
            DateTime incorrectBirthDate;
            DateTime incorrectCustomerDate;
            int incorrectTotalPurchases;

            // Act:
            incorrectBirthDate = new(1500, 01, 01);
            incorrectCustomerDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            incorrectTotalPurchases = -1;
            call = () => new Customer(incorrectBirthDate, incorrectTitleOfCourtesy, incorrectCustomerDate, incorrectTotalPurchases);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidCustomerMutation()
        {
            // Arrange:
            Func<Customer> call;
            DateTime incorrectDate;
            DateTime incorrectCustomerDate;
            int incorrectTotalPurchases;
            string incorrectTitleOfCourtesy;

            // Act:
            incorrectTotalPurchases = -1;
            incorrectDate = new(1500, 01, 01);
            incorrectCustomerDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            call = () => new Customer(incorrectDate, incorrectTitleOfCourtesy, incorrectCustomerDate, incorrectTotalPurchases);

            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion

        #region Employee tests
        [Fact]
        public void ValidEmployeeProperties()
        {
            // Arrange:
            string correctJobTitle;
            DateTime correctEmploymentDate;
            decimal correctYearlySalary;
            Employee e;

            // Act:
            correctEmploymentDate = DateTime.Now;
            correctJobTitle = "Salesman";
            correctYearlySalary = 300000.00m;
            e = new(DateTime.Now, "Title of Courtesy", correctJobTitle, correctEmploymentDate, correctYearlySalary);


            // Assert:
            Assert.False(String.IsNullOrWhiteSpace(e.TitleOfCourtesy));
            Assert.False(String.IsNullOrWhiteSpace(e.JobTitle));
            Assert.False(e.BirthDate.Year < 1900);
            Assert.False(e.EmploymentDate.Year < 1900);
            Assert.False(e.YearlySalary < 0);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidEmployeeProperties()
        {
            // Arrange:
            Func<Employee> call;
            string incorrectTitleOfCourtesy;
            DateTime incorrectBirthDate;
            DateTime incorrectEmploymentDate;
            decimal incorrectYearlySalary;
            string incorrectJobTitle;
            Employee e;


            // Act:
            incorrectBirthDate = new(1500, 01, 01);
            incorrectEmploymentDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            incorrectYearlySalary = -1;
            incorrectJobTitle = null;
            call = () => new Employee(incorrectBirthDate, incorrectTitleOfCourtesy, incorrectJobTitle, incorrectEmploymentDate, incorrectYearlySalary);


            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidEmployeeMutation()
        {
            // Arrange:
            Func<Employee> call;
            string incorrectTitleOfCourtesy;
            DateTime incorrectBirthDate;
            DateTime incorrectEmploymentDate;
            string incorrectJobTitle;
            decimal incorrectYearlySalary;

            // Act:
            incorrectJobTitle = null;
            incorrectYearlySalary = -1;
            incorrectEmploymentDate = new(1500, 01, 01);
            incorrectBirthDate = new(1500, 01, 01);
            incorrectTitleOfCourtesy = null;
            call = () => new Employee(incorrectBirthDate, incorrectTitleOfCourtesy, incorrectJobTitle, incorrectEmploymentDate, incorrectYearlySalary);

            // Assert:
            Assert.Throws<ArgumentOutOfRangeException>(call);
        }
        #endregion
    }
}