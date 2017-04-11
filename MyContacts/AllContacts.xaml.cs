using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MyContacts
{
	public partial class AllContacts : ContentPage
	{
        // Create a new boolean field named isEditing and flip the state of the boolean in your OnEdit handler.
		bool isEditing;

        // -------------------------------------------------------------------------------------------------------------------------- //

		public AllContacts()
		{
			InitializeComponent();
		}

        // -------------------------------------------------------------------------------------------------------------------------- //

		/* The ItemTapped event passes an ItemTappedEventArgs which has the actual object from the collection assigned to 
		   the ItemsSource property, however it needs to be cast. Recall that in this application, each data item is 
		   represented by a Person object. Go ahead and pull that object out from the event arguments and cast it to a Person. */
		async void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (!isEditing)
			{
				Person tappedPerson = (Person)e.Item;
				await this.Navigation.PushAsync(new ContactDetails(tappedPerson));
			}
		}

		// -------------------------------------------------------------------------------------------------------------------------- //

		void OnEdit(object sender, EventArgs e)
		{
            /* Based on whether the flag is true or false, set the Text property for the ToolBarItem to be "Edit" or "End Edit".
               Tip: use the sender parameter to get to the ToolBarItem. */
			isEditing = !isEditing;
			((ToolbarItem)sender).Text = isEditing ? "End Edit" : "Edit";   
		}

        // -------------------------------------------------------------------------------------------------------------------------- //

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            /* Check the isEditing field, and if it's true, then prompt the user with DisplayAlert whether they want to 
			   delete the Person passed in the SelectedItemChangedEventArgs. You will want to pass a "Yes" and "No" choice. */
	        if (isEditing)
	        {
		        Person person = (Person)e.SelectedItem;

		        if (person != null)
		        {
                    // If the user responds "Yes", then remove the Person from the SimpsonFactory.Characters collection.
			        if (await this.DisplayAlert("Confirm", "Are you sure you want to delete " + person.Name, "Yes", "No") == true)
			        {
				        SimpsonFactory.Characters.Remove(person);
			        }
		        }
                /* If we are in edit mode, call the OnEdit method to turn off edit mode when an item is deleted. 
				   You will need to pass the ToolBarItem as the sender.Equals */
		        OnEdit(editButton, EventArgs.Empty);
            }
        }

        // -------------------------------------------------------------------------------------------------------------------------- //

        // Add a bool reverse field to indicate which order the collection is in currently. It should default to false.
        bool reverse;

        void OnRefreshing(object sender, EventArgs e)
        {
	        ListView lv = (ListView)sender;

			/* In the Refresh handler, examine the reverse field value:
               If true use OrderBy to order the collection using the Name property.
               If false use OrderByDescending to order the collection in descending order using the Name property.
               Take the result and use ToList() to put evaluate it and place it into a separate list. */
	        var reversedData = ((reverse)
		    ? SimpsonFactory.Characters.OrderBy(p => p.Name)
		    : SimpsonFactory.Characters.OrderByDescending(p => p.Name)).ToList();
			
            // Flip the value of your reverse flag so the next time through it will re-sort in the opposite order.
	        reverse = !reverse;

            // Clear the existing collection using the Clear method.
	        SimpsonFactory.Characters.Clear();

            /* Add the contents of the reversed collection to the SimpsonFactory.Characters collection - 
			   this will refresh the UI with the new data. Unfortunately, ObservableCollection does not 
			   have an AddRange method - just use a foreach loop to add the items. */
	        foreach (var item in reversedData)
		         SimpsonFactory.Characters.Add(item);

            /* Finally, set the IsRefreshing property on the ListView to false to indicate we are done 
			   refreshing the data. You can case the sender parameter to get to the ListView. */
	        lv.IsRefreshing = false;
        }

        // -------------------------------------------------------------------------------------------------------------------------- //
	}
}

