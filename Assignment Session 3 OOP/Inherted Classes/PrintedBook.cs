using Assignment_Session_3_OOP.Classes;

namespace Assignment_Session_3_OOP.Inherted_Classes
{
    internal class PrintedBook : Book //inherited(derived) Class from Book
    {
        #region Properties
        public int PageCount { get; set; }
        #endregion

        #region Constructors
        public PrintedBook(string? title, string? author, string? iSBN, int pagecount) : base(title, author, iSBN)
        {
            PageCount = pagecount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Title={Title}\nAutor={Author}\nISBN={ISBN}\nPageCount={PageCount}";
        }
        public new void MyFunc()
        {
            Console.WriteLine("I Am child");
        }
        #endregion
    }
}
