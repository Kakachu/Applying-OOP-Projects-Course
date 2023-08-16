namespace UtmBuilder.Core.ValueObjects.Exceptions
{
	public class InvalidUserNameException : Exception
	{
		public const string DefaultErrorMessage = "Invalid UserName";

        public InvalidUserNameException(string message = DefaultErrorMessage)
			:base(message)
        {
            
        }
        public static void ThrowIfNull(string? firstName, string? lastName, string message = DefaultErrorMessage)
		{
			string userName = $"{firstName} {lastName}";

			if(string.IsNullOrEmpty(userName))
				throw new InvalidUserNameException(message);

			if(string.IsNullOrEmpty(firstName))
				throw new InvalidUserNameException("Invalid name");

			if (string.IsNullOrEmpty(lastName))
				throw new InvalidUserNameException("Invalid lastName");
		}
	}
}
