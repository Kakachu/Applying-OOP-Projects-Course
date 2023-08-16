using System.Linq;

namespace UtmBuilder.Core.Extensions
{
	public static class ListExtensions
	{
		public static void AddIfNotNull(this List<string> list, string key, string? value)
		{
			if (!string.IsNullOrEmpty(value))
				list.Add($"{key}={value}");
		}

		public static string OnlyLetters(this string input)
		{
			if (!string.IsNullOrEmpty(input))
			{
				input = new String(input.Where(Char.IsLetter).ToArray());
				return input;
			}

			return string.Empty;
		}

		public static string OnlyNumbers(this string input)
		{
			if (!string.IsNullOrEmpty(input))
			{
				input = new String(input.Where(Char.IsDigit).ToArray());
				return input;
			}

			return string.Empty;
		}
	}
}
