using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyContacts
{
	public class Person : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate {};

		public string HeadshotUrl { get; set; }

		string name;
		public string Name { 
			get { return name; }
			set { SetProperty(ref name, value);	}
		}

		string email;
		public string Email {
			get { return email; }
			set { SetProperty(ref email, value); }
		}

		DateTime dob;
		public DateTime Dob {
			get { return dob; }
			set { SetProperty(ref dob, value);	}
		}

		Gender gender;
		public Gender Gender {
			get { return gender; }
			set { SetProperty(ref gender, value); }
		}
		bool isFavorite;
		public bool IsFavorite {
			get { return isFavorite; }
			set { SetProperty(ref isFavorite, value); }
		}

		/// <summary>
		/// Method to compare and replace a field's value and raise a 
		/// PropertyChanged notification if it was altered.
		/// </summary>
		/// <returns><c>true</c>, if field was set, <c>false</c> otherwise.</returns>
		/// <param name="field">Field.</param>
		/// <param name="value">Value.</param>
		/// <param name="propertyName">Property name.</param>
		/// <typeparam name="T">Field type.</typeparam>
		bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "") 
		{
			if (!object.Equals(field, value)) {
				field = value;
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
    
}
