using System;
namespace MVCCountries
{
	public class CountryListView
	{
	
		public CountryListView(List<Country> countries)
		{
			this.Countries = Countries;
		}
		public List<Country> Countries { get; set; }

		public void Display()
        {
			for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}: {Countries[i].Name}");
            }
        }
	}
}

