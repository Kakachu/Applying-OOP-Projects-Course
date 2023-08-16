using System.Text.RegularExpressions;
using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
	public class Password : ValueObjects
	{
        public Password(string passwordKeys)
        {

            PasswordKeys = passwordKeys;
            Letters = passwordKeys.OnlyLetters();
            Numbers = passwordKeys.OnlyNumbers();

            InvalidPasswordException.ThrowIfNull(Letters, Numbers);
        }

        public string PasswordKeys { get; set; }

        public string Letters { get; private set; }

		public string Numbers { get; private set; }

	}
}
