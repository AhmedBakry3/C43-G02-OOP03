using Assignment_Session_3_OOP.Classes;
using Assignment_Session_3_OOP.Inherted_Classes;
using Assignment_Session_3_OOP.Enums;
using static Assignment_Session_3_OOP.Classes.Employee;
namespace Assignment_Session_3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Design and implement a Class for the employees in a company: Notes :
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //We need to restrict the Gender field to be only M or F[Male or Female]
            //Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].

            //In question 1 , I made
            //1-Employee Class
            //3-Enum For Gender
            //4-Enum For Security level
            //5-Enum
            #endregion

            #region 2.Develop a Class to represent the Hiring Date Data:
            //Consisting of fields to hold the day, month and Years.

            //In Question2 , I made
            //1-HiringDate Class

            #endregion

            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //Define all the Necessary Constructors for the Class
            //Allow NO RUNTIME errors if the user inputs any data
            //Write down all the necessary Properties(Instead of setters and getters)

            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Ahmed", 75000, (SecurityLevel)1, new HiringDate(15, 3, 2020), Gender.M);  //guest
            EmpArr[1] = new Employee(2, "Salma", 60000, (SecurityLevel)8, new HiringDate(22, 8, 2018), Gender.F); // DBA
            EmpArr[2] = new Employee(3, "Mohamed", 90000, (SecurityLevel)15, new HiringDate(10, 12, 2021), Gender.M); //Full Permissions




            #endregion

            #region 4.Sort the employees based on their hire date then Print the sorted array.
            //While sorting (how many times Boxing and Unboxing process has occurred)

            // Sorting using IComparer<Employee>
            Array.Sort(EmpArr, new HiringDateComparer());

            // Displaying sorted employees
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

            //While Sorting 
            //Boxing Occurred 10 Times
            //unboxing occurred 10 Times



            #endregion

            #region 5-Design a program for a library management system where:
            //Book is a base class with properties like Title, Author, and ISBN.
            //EBook and PrintedBook are derived classes with additional properties like FileSize for EBook and PageCount for PrintedBook.
            //Demonstrate how inheritance simplifies the design.

            //Creating Object from Parent(base)class => Book
            Book book = new Book("CS", "Ahmed", "123-456-789");
            Console.WriteLine(book); //since we override in tostring() function which was accessible to override cuz its virtual in implementation
                                     //output :
                                     //Title=CS
                                     //Autor = Ahmed
                                     //ISBN = 123 - 456 - 789
            book.MyFunc(); //I Am Parent 

            //Since that ebook is inherited(derived) so it can reach to Book Instances and can set or get them by using Constructor Chanining with "Base()" KeyWord & Methods and can override on them if the method is virtual or by using "New" Keyword
            //Creating Object from inherted(Derived)class => EBook
            EBook ebook = new EBook("CS", "Ahmed", "123-456-789", 5.2); // since its inherited from Book it can get its values
            ebook.Title = "AI"; // since its inherited from Book it can also set its values
            ebook.Author = "Mohamed";
            ebook.ISBN = "482-359-423";
            ebook.FileSize = 15.5; // this its original variable , it didnt inhert it from Book
            Console.WriteLine(ebook); //since we override in tostring() function which was accessible to override cuz its virtual in implementation 
                                      //output :
                                      //Title=AI
                                      //Autor = Mohamed
                                      //ISBN = 482 - 359 - 423
                                      //FileSize = 15.5 MB
            ebook.MyFunc(); //I Am child 
                            //since we use "new" keyword we override on the Myfunc() Method from Book Class and give it a new message


            //Since that printedBook is inherited(derived) so it can reach to Book Instances and can set or get them by using Constructor Chanining with "Base()" KeyWord & Methods and can override on them if the method is virtual or by using "New" Keyword
            //Creating Object from inherted(Derived)class => PrintedBook
            PrintedBook printedBook = new PrintedBook("CS", "Ahmed", "123-456-789", 150); // since its inherited from Book it can get its values
            printedBook.Title = "IS"; // since its inherited from Book it can also set its values
            printedBook.Author = "Mahmoud";
            printedBook.ISBN = "425-364-483";
            printedBook.PageCount = 300; // this its original variable , it didnt inhert it from Book
            Console.WriteLine(printedBook); //since we override in tostring() function which was accessible to override cuz its virtual in implementation 
                                            //output :
                                            //Title=AI
                                            //Autor = Mohamed
                                            //ISBN = 482 - 359 - 423
                                            //PageCount = 300
            printedBook.MyFunc(); //I Am child 
                                  //since we use "new" keyword we override on the Myfunc() Method from Book Class and give it a new message


            #endregion
        }
    }
}
