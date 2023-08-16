using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core
{
	public class Student
    {
        public Student(UserName userName, Password password, Email email, Social social)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Social = social;

            InvalidPasswordException.ThrowIfInvalid(password);
        }

        public UserName UserName { get; private set; }

        public Password Password { get; private set; }

        public Email Email { get; private set; }

        public Social Social { get; private set; }
	}
}
