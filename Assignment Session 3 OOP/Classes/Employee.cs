using Assignment_Session_3_OOP.Enums;

namespace Assignment_Session_3_OOP.Classes
{
    internal class Employee
    {
        #region Attributes 
        private int ID;
        private string name;
        private decimal salary;

        #region Properties & Methods 

        // Getter and Setter for ID
        //public int GetId()
        //{
        //    return id;
        //}

        //public void SetId(int value)
        //{
        //    if (value > 0)
        //        id = value;
        //    else
        //        Console.WriteLine("Invalid ID value.");
        //}

        public int Id // Property for Name

        {
            get { return ID; }
            set
            {
                if (value > 0)
                    ID = value;
                else
                    Console.WriteLine("Invalid ID value");
            }
        }
        //======================================================================
        //======================================================================

        // Getter and Setter for Name
        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string value)
        //{
        //    if (!string.IsNullOrEmpty(value))
        //        name = value;
        //    else
        //        Console.WriteLine("Name cannot be empty");
        //}
        // Property for Name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty");
            }
        }
        //======================================================================
        //======================================================================

        //// Getter and Setter for Salary
        //public decimal GetSalary()
        //{
        //    return salary;
        //}

        //public void SetSalary(decimal value)
        //{
        //    if (value >= 0)
        //        salary = value;
        //    else
        //        Console.WriteLine("Salary cannot be negative.");
        //}
        // Property for Salary
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary cannot be negative");
            }
        }

        // Property for Security Level (using enum)
         public SecurityLevel securitylevel { get; set; } // Since there is not logic to put , we will do it with automatic property

        // Property for HireDate (using enum)
        public HiringDate HiringDate { get; set; } // Since there is not logic to put , we will do it with automatic property


        // Property for Gender (using enum)
        public Gender gender { get; set; } // Since there is not logic to put , we will do it with automatic property

        #endregion


        public override string ToString()
        {
            return string.Format("ID = {0} , Name = {1} , Salary = {2:c} , Security Level = {3} , Hiring Date = {4} , Gender = {5}", ID, Name, Salary, securitylevel, HiringDate, gender);
        }
        #endregion

        // to sort Employee Based on Hiring Date
        public class HiringDateComparer : IComparer<Employee>
        {
            public int Compare(Employee empA, Employee empB)
            {
                // Compare by Year first
                if (empA.HiringDate.Year != empB.HiringDate.Year)
                    return empA.HiringDate.Year.CompareTo(empB.HiringDate.Year);

                // If years are equal, compare by Month
                if (empA.HiringDate.Month != empB.HiringDate.Month)
                    return empA.HiringDate.Month.CompareTo(empB.HiringDate.Month);

                // If months are also equal, compare by Day
                return empA.HiringDate.Day.CompareTo(empB.HiringDate.Day);
            }
        }

        #region Constructors
        public Employee(int id, string name, decimal salary, SecurityLevel securityLevel, HiringDate hiringDate, Gender gender)
        {
            ID = id;
            Name = name;
            Salary = salary;
            this.securitylevel = securityLevel;
            HiringDate = hiringDate; 
            this.gender = gender;
        }

        #endregion

    }
}
