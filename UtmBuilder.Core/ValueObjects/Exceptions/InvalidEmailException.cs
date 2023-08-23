using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
	public partial class InvalidEmailException : Exception
	{
		public const string DefaultErrorMessage = "Invalid Email";

		public InvalidEmailException(string message = DefaultErrorMessage)
			: base(message)
		{

		}

		public static void ThrowIfInvalid(string email, string message = DefaultErrorMessage)
		{
			if(string.IsNullOrEmpty(email))
				throw new InvalidEmailException(message);

			if(!EmailRegex().IsMatch(email))
				throw new InvalidEmailException(message);
		}

		[GeneratedRegex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
		private static partial Regex EmailRegex();
	}
}
