using System;
namespace MVCCountries
{
	public class CountryView
	{
		public Country DisplayCountry { get; set; }

		public CountryView(Country DisplayCountry)
		{
			this.DisplayCountry = DisplayCountry;
		}
		public void Display()
        {
            Console.WriteLine("Country Display");
            Console.WriteLine($"Name:  {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            //Console.WriteLine($"Colors: {DisplayCountry.Colors}");
        }

	} 

}

