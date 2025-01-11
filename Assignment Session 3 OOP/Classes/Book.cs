namespace Assignment_Session_3_OOP.Classes
{
    internal class Book //Parent(Base) Class
    {
        #region properties
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        #endregion

        #region Constructors

        public Book(string? title, string? author, string? iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Title={Title}\nAutor={Author}\nISBN={ISBN}";
        }
        public void MyFunc()
        {
            Console.WriteLine("I Am Parent");
        }
        #endregion

    }
}
