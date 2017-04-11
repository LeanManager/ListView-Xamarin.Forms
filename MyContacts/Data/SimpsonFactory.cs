using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyContacts
{
	public static class SimpsonFactory
	{
     /* Examine the definition of the SimpsonFactory.Characters collection in the Data folder. 
        It's currently a List<Person> collection which does not report changes.Change it to be an 
        ObservableCollection<Person> type and re-run your test - it should now delete the row. */

		public static ObservableCollection<Person> Characters { get; private set; }

		static SimpsonFactory()
		{
			Characters = new ObservableCollection<Person> 
			{
				new Person 
				{ 
					Name = "Homer Simpson", 
					HeadshotUrl = "Homer.gif", 
					Email = "donutlover@aol.com", 
					Dob = new DateTime(1965, 1, 24),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{
					Name = "Marge Simpson",
					HeadshotUrl = "Marge.gif",
					Email = "mamma_marge@gmail.com",
					Dob = new DateTime(1966, 6, 4),
					Gender = Gender.Female,
					IsFavorite = true,
				},

				new Person 
				{ 
					Name = "Bart Simpson",
					HeadshotUrl = "Bart.gif",
					Email = "troublemaker@gmail.com",
					Dob = new DateTime(2006, 02, 02),
					Gender = Gender.Male,
					IsFavorite = true,
				},

				new Person 
				{ 
					Name = "Lisa Simpson",
					HeadshotUrl = "Lisa.gif",
					Email = "cooljazz@gmail.com",
					Dob = new DateTime(2008, 12, 02),
					Gender = Gender.Female,
					IsFavorite = true,
				},

				new Person 
				{ 
					Name = "Maggie Simpson",
					HeadshotUrl = "Maggie.gif",
					Email = "babysimpson@gmail.com",
					Dob = new DateTime(2009, 09, 15),
					Gender = Gender.Female,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Krusty the Clown",
					HeadshotUrl = "Krusty.gif",
					Email = "funnyguy@krustytheclown.com",
					Dob = new DateTime(1972, 04, 12),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Apu Nahasapeemapetilon",
					HeadshotUrl = "Apu.gif",
					Email = "storekeeper@quikeemart.com",
					Dob = new DateTime(1977, 09, 03),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Comic Book Guy",
					HeadshotUrl = "ComicBookGuy.gif",
					Email = "comics@nerd.com",
					Dob = new DateTime(1969, 10, 30),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Milhouse van Houten",
					HeadshotUrl = "Milhouse.gif",
					Email = "iammilhouse@aol.com",
					Dob = new DateTime(2006, 10, 12),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Moe Szyslak",
					HeadshotUrl = "MoeSzyslak.gif",
					Email = "moe@moesbar.com",
					Dob = new DateTime(1961, 09, 22),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Mr. Burns",
					HeadshotUrl = "MrBurns.gif",
					Email = "theman@boss.com",
					Dob = new DateTime(1950, 11, 7),
					Gender = Gender.Male,
					IsFavorite = false,
				},

				new Person 
				{ 
					Name = "Sideshow Bob",
					HeadshotUrl = "SideshowBob.gif",
					Email = "secondfiddle@krustytheclown.com",
					Dob = new DateTime(1982, 4, 9),
					Gender = Gender.Male,
					IsFavorite = true,
				},

				new Person 
				{ 
					Name = "Waylon Smithers",
					HeadshotUrl = "WaylonSmithers.gif",
					Email = "lackey@boss.com",
					Dob = new DateTime(1986, 5, 30),
					Gender = Gender.Male,
					IsFavorite = false,
				},
			};
		}
	}
}

