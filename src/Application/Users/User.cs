using System;
namespace Application.Users
{
	public class User
	{
		private string _name;

		public User(string name)
		{
			if(name == null)
			{
				throw new  ArgumentNullException(nameof(name), "Name cannot be null");
			}
			_name = name;
		}

		public string Name
		{
			get { return _name; }
			set
			{
				if(value == null)
				{
					throw new ArgumentNullException(nameof(value), "Value canot be null");
				}

				_name = value;
			}
		}
	

	}
	

	
}

