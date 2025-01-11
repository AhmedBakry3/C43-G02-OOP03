
using Assignment_Session_3_OOP.Classes;
using System.Security.Claims;

namespace Assignment_Session_3_OOP.Inherted_Classes
{
    internal class EBook : Book //inherited(derived) Class from Book
    {
        #region Properties
        public double FileSize { get; set; }
        #endregion

        #region Constructors
        public EBook(string? title, string? author, string? iSBN, double filesize) : base(title, author, iSBN)
        {
            FileSize = filesize;
        }

        #region Methods

        public override string ToString()
        {
            return $"Title={Title}\nAutor={Author}\nISBN={ISBN}\nFileSize={FileSize} MB";
        }
        public new void MyFunc()
        {
            Console.WriteLine("I Am child");
        }
        #endregion

        #endregion
    }
}
