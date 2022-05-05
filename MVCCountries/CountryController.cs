using System;
namespace MVCCountries
{
	public class CountryController
	{

		public List<Country> CountryDB { get; set; } = new List<Country>();

		public CountryController()
		{
			CountryDB.Add(new Country("USA", ContinentType.NorthAmerica));
			//CountryDB.Add(new Country { Name = "Argentina", Continent = ContinentType.SouthAmerica, Colors = { "Light Blue", "White" }});
			//CountryDB.Add(new Country { Name = "Germany", Continent = ContinentType.Europe, Colors = { "Orange", "Black" } });
			//CountryDB.Add(new Country { Name = "South Africa", Continent = ContinentType.Africa, Colors = { "yellow", "green" }});
			//CountryDB.Add(new Country { Name = "North Korea", Continent = ContinentType.Asia, Colors = { "Red", "White",} });
			//CountryDB.Add(new Country { Name = "Austrialia", Continent = ContinentType.Australia, Colors = { "Purple", "Maroon" } });
		}

		public void CountryAction(Country c)
        {
			CountryView cv = new CountryView(c);
			cv.Display();
        }
		public void WelcomeAction()
        {
			CountryListView clv = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list.");
			clv.Display();
			int index = int.Parse(Console.ReadLine());
			CountryAction(CountryDB[index]);

		}
	}
}

