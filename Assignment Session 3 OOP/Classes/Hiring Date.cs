
namespace Assignment_Session_3_OOP.Classes
{
    internal class HiringDate
    {
        #region properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        #endregion
        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }


        #endregion
    }
}
