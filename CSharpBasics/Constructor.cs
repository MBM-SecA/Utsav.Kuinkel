namespace AllAboutClasses
{
    public class Country
    {

        public string name { get; set; }
        public int area { get; set; }

        public static readonly bool isOnEarth;
        //default constructor
        public Country()
        {

        }

        //parameterized constructor
        public Country(string country)
        {
            name = country;
        }

        //static constructor
        static Country()
        {
            isOnEarth = true;
        }

        ~Country()
        {

        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
        }
    }
}