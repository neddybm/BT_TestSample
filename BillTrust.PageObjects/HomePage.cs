using OpenQA.Selenium;
using Golem.WebDriver;

namespace BillTrust.PageObjects
{
    public class HomePage : BtBasePageObject
    {
        // ---global variables--- //
        
        // ---banner elements--- //
        private readonly Element _infoBtn = new Element(By.XPath("//a[contains(.,'Tell Me More')]"));
        private readonly Element _demoBtn = new Element(By.XPath("//a[contains(.,'Request a Demo')]"));

        // ---quantum section elements--- //
        private readonly Element _paymentCycleBtn = new Element(By.XPath("//a[contains(.,'What’s Payment Cycle Management?')]"));
        private readonly Element _showMeQuantumBtn = new Element(By.XPath("//a[contains(.,'Show Me Quantum')]"));
        
        // ---simple steps elements--- //
        private readonly Element _quantumInvoicingBtn = new Element(By.XPath("//a[contains(.,'Invoicing')]"));
        private readonly Element _quantumPaymentsBtn = new Element(By.XPath("//a[contains(.,'Payments')]"));
        private readonly Element _quantumCashBtn = new Element(By.XPath("//a[contains(.,'Cash Application')]"));
        private readonly Element _erpsSupportBtn = new Element(By.XPath("//a[contains(.,'Which ERPs')]"));

        // ---demo panel elements--- //
        private readonly Element _requestDemoBtn = new Element(By.XPath("//a[contains(.,'REQUEST A DEMO')]"));

        public override void WaitForElements()
        {
            _infoBtn.Verify().Visible();
            _demoBtn.Verify().Visible();
            _paymentCycleBtn.Verify().Visible();
            _showMeQuantumBtn.Verify().Visible();
            _quantumInvoicingBtn.Verify().Visible();
            _quantumPaymentsBtn.Verify().Visible();
            _quantumCashBtn.Verify().Visible();
            _erpsSupportBtn.Verify().Visible();
            _requestDemoBtn.Verify().Visible();
        }

        public RequestDemoPage ToRequestDemo()
        {
            
            _requestDemoBtn.Click();
            return new RequestDemoPage();
        }
    }
}
