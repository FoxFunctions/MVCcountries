using System;
namespace MVCCountries
{
	public enum ContinentType
    {
		NorthAmerica,
		SouthAmerica,
		Europe,
		Asia,
		Australia,
		Africa,
		Antartica,
    }
	public class Country
	{
		public string Name { get; set; }
		public ContinentType Continent { get; set; }
		//public List<string> Colors { get; set; }

		public Country(string Name, ContinentType Continent)
        {
			this.Name = Name;
			this.Continent = Continent;
			//this.Colors = Colors;
        }
	
	}
}

