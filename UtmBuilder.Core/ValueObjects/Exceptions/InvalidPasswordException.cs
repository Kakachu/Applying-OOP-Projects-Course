namespace UtmBuilder.Core.ValueObjects.Exceptions
{
	public class InvalidPasswordException : Exception
	{
		public const string DefaultErrorMessage = "Invalid Password";

        public InvalidPasswordException(string message = DefaultErrorMessage)
			: base(message)
        {
				
        }

        public static void ThrowIfInvalid(Password password)
		{
			if (string.IsNullOrEmpty(password.Letters))
				throw new InvalidPasswordException("Your password must have letters");

			if (string.IsNullOrEmpty(password.Numbers))
				throw new InvalidPasswordException("Your password must have numbers");

			if (password.Letters.Length < 8)
				throw new InvalidPasswordException("Your password must have a minimal of 8 letters");

			if (password.Numbers.Length < 2)
				throw new InvalidPasswordException("Your password must have a minimal of 2 numbers");
		}

		public static void ThrowIfNull(string letters, string numbers)
		{
			if (string.IsNullOrEmpty(letters) || string.IsNullOrEmpty(numbers))
				throw new InvalidPasswordException();
		}
	}
}
