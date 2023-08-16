namespace UtmBuilder.Core.ValueObjects.Exceptions
{
	public class InvalidSocialException : Exception
	{
		public const string DefaultErrorMessage = "Invalid social media nickname";

        public InvalidSocialException(string message = DefaultErrorMessage)
			:base(message)
        {
            
        }
        public static void ThrowIfInvalid(UserName? nickname, string message = DefaultErrorMessage)
		{
			if(nickname == null)
				throw new InvalidSocialException(message);

			if (string.IsNullOrEmpty(nickname.FirstName + nickname.LastName))
				throw new InvalidSocialException(message);

			if (!nickname.FirstName.StartsWith("@"))
				throw new InvalidSocialException("First character must be a '@'");
		}
	}
}
