using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
	[TestClass]
	public class UtmTests
	{
		private const string _result = "https://www.youtube.com/?utm_source=src&utm_medium=med&utm_campaign=nme&utm_id=id&utm_term=ter&utm_content=ctn";
		private readonly Url _url = new ("https://www.youtube.com/");
		private readonly Campaign _campaign = new("src", "med", "nme", "id", "ter", "ctn");

		[TestMethod]
		public void ShouldReturnUrlFromUtm()
		{
			var utm = new Utm(_url, _campaign);
			Assert.AreEqual(_result, utm.ToString());
			Assert.AreEqual(_result, (string)utm);
		}

		[TestMethod]
		public void ShouldReturnUtmFromUrl()
		{
			Utm utm = _result;
			Assert.AreEqual("https://www.youtube.com/", utm.Url.Address);
			Assert.AreEqual("src", utm.Campaign.Source);
			Assert.AreEqual("med", utm.Campaign.Medium);
			Assert.AreEqual("nme", utm.Campaign.Name);
			Assert.AreEqual("id", utm.Campaign.Id);
			Assert.AreEqual("ter", utm.Campaign.Term);
			Assert.AreEqual("ctn", utm.Campaign.Content);
		}
	}
}
