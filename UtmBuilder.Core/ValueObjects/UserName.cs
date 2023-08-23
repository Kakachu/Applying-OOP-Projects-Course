using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class UserName : ValueObjects
    {
        public UserName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            InvalidUserNameException.ThrowIfNull(firstName, lastName);
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            InvalidUserNameException.ThrowIfNull(FirstName, LastName);
            var userName = $"{FirstName} {LastName}";
            return userName;
        }

        public static implicit operator UserName(string name) 
        {
            var parameters = name.Split(' ');
            var firstName = parameters[0];
            var lastName = parameters[1];

            if(parameters.Length > 2)
            {
                for (int i = 2; i < parameters.Length; i++)
                {
                    lastName += ' ' + parameters[i];
                }
            }

            var userName = new UserName(firstName, lastName);
            return userName;
        }
	}
}
