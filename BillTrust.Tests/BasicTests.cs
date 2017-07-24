using BillTrust.PageObjects;
using Golem;
using NUnit.Framework;

namespace BillTrust.Tests
{
    public class BasicTests : WebDriverTestBase
    {
        string url = "https://www.billtrust.com/";

        [Test]
        public void HeaderTests()
        {
            driver.Navigate().GoToUrl(url);
            new HomePage().ToRequestDemo().RequestDemoForm("automated", "tester", "neddy.test@gmail.com", "personal", "303-111-1111");
        }
    }
}
