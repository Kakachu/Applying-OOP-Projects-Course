using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
	[TestClass]
	public class StudentTests
	{
		private const string _userName = "kauã jardim da silva";
		private const string _firstName = "kauã";
		private const string _lastName = "jardim da silva";

		[TestMethod]
		public void ShouldReturnUserNameFromFirstAndLastName() 
		{
			var userName = new UserName(_firstName, _lastName);
			Assert.AreEqual(_userName, userName.ToString());
			Assert.AreEqual(_firstName, userName.FirstName);
			Assert.AreEqual(_lastName, userName.LastName);
		}

		[TestMethod]
		public void ShouldReturnFirstAndLastNameFromUserName()
		{
			UserName userName = (_userName);
			Assert.AreEqual("kauã", userName.FirstName);
			Assert.AreEqual("jardim da silva", userName.LastName);
		}
	}
}
