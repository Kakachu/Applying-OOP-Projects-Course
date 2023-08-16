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

        public static implicit operator string(UserName userName)
        => userName.ToString();
	}
}
