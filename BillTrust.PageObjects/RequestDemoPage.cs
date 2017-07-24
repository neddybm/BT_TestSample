using Golem.Core;
using OpenQA.Selenium;
using Golem.WebDriver;

namespace BillTrust.PageObjects
{
    public class RequestDemoPage : BtBasePageObject
    {
        private readonly Element _fNameFld = new Element(By.XPath("//form[@id='mktoForm_1047']//input[@id='FirstName']"));
        private readonly Element _lNameFld = new Element(By.XPath("//form[@id='mktoForm_1047']//input[@id='LastName']"));
        private readonly Element _emailFld = new Element(By.XPath("//form[@id='mktoForm_1047']//input[@id='Email']"));
        private readonly Element _companyFld = new Element(By.XPath("//form[@id='mktoForm_1047']//input[@id='Company']"));
        private readonly Element _phoneFld = new Element(By.XPath("//form[@id='mktoForm_1047']//input[@id='Phone']"));
        private readonly Element _submitBtn = new Element(By.XPath("//form[@id='mktoForm_1047']//button[@class='mktoButton']"));

        public override void WaitForElements()
        {
            _fNameFld.Verify().Visible();
            _lNameFld.Verify().Visible();
            _emailFld.Verify().Visible();
            _companyFld.Verify().Visible();
            _phoneFld.Verify().Visible();
            _submitBtn.Verify().Visible();
        }

        public void RequestDemoForm(string fName, string lName, string email, string cName, string phone)
        {
            _fNameFld.SetText(fName);
            _lNameFld.SetText(lName);
            _emailFld.SetText(email);
            _companyFld.SetText(cName);
            _phoneFld.SetText(phone);
            Common.Delay(5000);
            _submitBtn.Verify().Visible();
        }
    }
}
