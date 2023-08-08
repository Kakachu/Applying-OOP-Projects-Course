using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
	[TestClass]
	public class UrlTests
	{
		private const string invalidUrl = "banana";
		private const string validUrl = "https://www.youtube.com";

		[TestMethod]
		[ExpectedException(typeof(InvalidUrlException))]
		public void ShouldReturnErrorWhenUrlIsInvalid()
		{
			new Url(invalidUrl);
		}

		[TestMethod]
		public void ShouldReturnErrorWhenUrlIsValid()
		{
			new Url(validUrl);
			Assert.IsTrue(true);
		}

		[TestMethod]
		[DataRow("banana", true)]
		[DataRow(" ", true)]
		[DataRow("http", true)]
		[DataRow("https://youtube.com", false)]
		public void TestUrl(string link, bool expectedException)
		{
			if (expectedException)
			{
				try
				{
					new Url(link);
					Assert.Fail();
				}
				catch (InvalidUrlException)
				{
					Assert.IsTrue(true);
				}
			}
		}
	}
}
