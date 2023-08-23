using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
	[TestClass]
	public class EmailTests
	{
		private const string invalidEmail = "gardencom";
		private const string validEmail = "garden@gmail.com";

		[TestMethod]
		[ExpectedException(typeof(InvalidEmailException))]
		public void ShouldReturnErrorWhenEmailIsInvalid()
		{
			new Email(invalidEmail);
		}

		[TestMethod]
		public void ShouldReturnErrorWhenEmailIsValid() 
		{
			new Email(validEmail);
			Assert.IsTrue(true);
		}

		[TestMethod]
		[DataRow(invalidEmail, true)]
		[DataRow("kkgarden", true)]
		[DataRow("ka,gamail.com", true)]
		[DataRow("kagamail@com", true)]
		[DataRow(validEmail, true)]
		public void EmailTest(string email, bool expectedException)
		{
			if(expectedException)
			{
				try
				{
					new Email(email);
					Assert.Fail();
				}
				catch
				{
					Assert.IsTrue(true);
				}
			}
		}
	}
}
