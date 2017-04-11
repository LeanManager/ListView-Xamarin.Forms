using Xamarin.Forms;
using System.Linq;

namespace MyContacts
{
    public class App : Application
    {
        public App()
        {
            // MainPage = new ContactDetails(SimpsonFactory.Characters.First());

			MainPage = new NavigationPage(new AllContacts());
        }
    }
}

/* When exposing lists of data, a best practice is to always expose an abstraction, 
   typically an interface such as IList<T> or IEnumerable<T>. In this fashion, the implementation 
   can be changed over time - for example you could start out with a List<T> and then change it to 
   something else without affecting the binary contract of the property. */

/* If the collection itself will be modified at runtime(not the items in the collection, 
   but the collection itself), then it will need to report collection change notifications.
   The easiest way to manage this is to use the ObservableCollection<T> which works like a List 
   but provides the change notifications. */